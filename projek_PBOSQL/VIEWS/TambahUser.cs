using projek_PBOSQL.MODELS.Pengguna;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projek_PBOSQL.VIEWS
{
    public partial class TambahUser : Form
    {
        public TambahUser()
        {
            InitializeComponent();
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            string usernameInput = txtUsername.Text.Trim();
            string passwordInput = txtPassword.Text.Trim();
            string noTelpInput = txtNoTelp.Text.Trim();

            string roleInput = "";
            if (RbAdmin.Checked)
            {
                roleInput = "1";
            }
            else if (RbPetani.Checked)
            {
                roleInput = "2";
            }
            else
            {
                MessageBox.Show("Silakan pilih Role terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(usernameInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Username dan Password wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (usernameInput.Length > 20)
            {
                MessageBox.Show("Username terlalu panjang! Maksimal 20 karakter.", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mencegah error VARCHAR(15) di kolom no_telp PostgreSQL
            if (noTelpInput.Length > 15)
            {
                MessageBox.Show("Nomor telepon terlalu panjang! Maksimal 15 karakter.", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (passwordInput.Length < 8 || passwordInput.Length > 15)
            {
                MessageBox.Show("Password harus diantara 8 dan 15.", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool bisaPetaniMode = chkCanUsePetaniMode.Checked;

            try
            {
                CONTROLLERS.c_KelolaUser controllerUser = new CONTROLLERS.c_KelolaUser();

                bool isBerhasil = controllerUser.TambahUser(usernameInput, passwordInput, noTelpInput, roleInput, bisaPetaniMode);

                if (isBerhasil)
                {
                    MessageBox.Show("User berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TambahUser_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            chkCanUsePetaniMode.Visible = RbAdmin.Checked;
        }

        private void RbPetani_CheckedChanged(object sender, EventArgs e)
        {
            if (RbPetani.Checked)
            {
                chkCanUsePetaniMode.Checked = false;
                chkCanUsePetaniMode.Visible = false;
            }
        }
    }
}
