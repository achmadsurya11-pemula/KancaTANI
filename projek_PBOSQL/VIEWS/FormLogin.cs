using Npgsql;
using projek_PBOSQL.MODELS.Pengguna;
using projek_PBOSQL.CONTROLLERS;
using System;
using System.Data.SqlTypes;
using projek_PBOSQL.VIEWS;
namespace projek_PBOSQL
{
    public partial class FormLogin : Form
    {
        private readonly c_users _userController = new c_users();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputUser = txtUsername.Text.Trim();
            string inputPass = txtPassword.Text.Trim();

            // Validasi input dasar 
            if (string.IsNullOrEmpty(inputUser) || string.IsNullOrEmpty(inputPass))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                User penggunaAktif = _userController.validasi_login(inputUser, inputPass);

                if (penggunaAktif != null)
                {
                    MessageBox.Show($"Selamat datang kembali, {penggunaAktif.Username}!", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (penggunaAktif.Role.ToLower() == "admin")
                    {
                        ADMIN dashboardAdmin = new ADMIN();
                        dashboardAdmin.Show();
                    }
                    else
                    {
                        PETANI dashboardPetani = new PETANI();
                        dashboardPetani.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah. Silakan coba lagi!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

