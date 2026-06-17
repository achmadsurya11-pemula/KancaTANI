using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projek_PBOSQL.VIEWS
{
    public partial class EditAkun : Form
    {
        public int IdAkunTerpilih;
        public EditAkun()
        {
            InitializeComponent();
        }

        private void btnSimpanEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEditUsername.Text) || string.IsNullOrWhiteSpace(txtEditNotelp.Text))
            {
                MessageBox.Show("Username dan Nomor Telepon tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CONTROLLERS.c_KelolaUser controllerUser = new CONTROLLERS.c_KelolaUser();

                bool isEditBerhasil = controllerUser.EditUser(IdAkunTerpilih, txtEditUsername.Text.Trim(), txtEditNotelp.Text.Trim(), txtEditPass.Text.Trim(), "");

                if (isEditBerhasil)
                {
                    MessageBox.Show("Data akun berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; 
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimpanEdit_Click_1(object sender, EventArgs e)
        {
             
            if (string.IsNullOrWhiteSpace(txtEditUsername.Text) || string.IsNullOrWhiteSpace(txtEditNotelp.Text))
            {
                MessageBox.Show("Username dan Nomor Telepon tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            
            string usernameBaru = txtEditUsername.Text.Trim();
            string noTelpBaru = txtEditNotelp.Text.Trim();
            string passwordBaru = txtEditPass.Text.Trim();

            if (usernameBaru.Length > 20)
            {
                MessageBox.Show("Username terlalu panjang! Maksimal 20 karakter.", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (noTelpBaru.Length > 15)
            {
                MessageBox.Show("Nomor telepon terlalu panjang! Maksimal 15 karakter.", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (passwordBaru.Length < 8 || passwordBaru.Length > 15)
            {
                MessageBox.Show("Password harus diantara 8 dan 15.", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CONTROLLERS.c_KelolaUser controllerUser = new CONTROLLERS.c_KelolaUser();

                bool isEditBerhasil = controllerUser.EditUser(IdAkunTerpilih, usernameBaru, noTelpBaru, passwordBaru, "");

                if (isEditBerhasil)
                {
                    MessageBox.Show($"Data akun '{usernameBaru}' berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui data akun. Pastikan data sesuai.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem saat menyimpan: " + ex.Message, "Error Aplikasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
    

