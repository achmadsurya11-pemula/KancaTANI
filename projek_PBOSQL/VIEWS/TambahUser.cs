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

            try
            {
                CONTROLLERS.c_KelolaUser controllerUser = new CONTROLLERS.c_KelolaUser();

                bool isBerhasil = controllerUser.TambahUser(usernameInput, passwordInput, noTelpInput, roleInput);

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

        }
    }
}
