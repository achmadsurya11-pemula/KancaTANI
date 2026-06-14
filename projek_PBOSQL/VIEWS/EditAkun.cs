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
            //Validasi Input 
            if (string.IsNullOrWhiteSpace(txtEditUsername.Text) || string.IsNullOrWhiteSpace(txtEditNotelp.Text))
            {
                MessageBox.Show("Username dan Nomor Telepon tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ambil data yang diketik user 
            string usernameBaru = txtEditUsername.Text.Trim();
            string noTelpBaru = txtEditNotelp.Text.Trim();
            string passwordBaru = txtEditPass.Text.Trim(); 

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
    

