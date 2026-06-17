using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace projek_PBOSQL.VIEWS
{
    public partial class KelolaUser : Form
    {
        int idAkunTerpilih = 0;
        public KelolaUser()
        {
            InitializeComponent();
            TampilkanDataUser();
            UserSummary();

        }

        private void TampilkanDataUser()
        {
            try
            {
                CONTROLLERS.c_KelolaUser controllerUser = new CONTROLLERS.c_KelolaUser();
                DataTable dt = controllerUser.GetAllAkun();

                if (dt != null && dt.Rows.Count > 0)
                {
                    DGV_kelUser.DataSource = dt;
                    DGV_kelUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DGV_kelUser.Columns["id_akun"].DisplayIndex = 0;
                    DGV_kelUser.Columns["username"].DisplayIndex = 1;
                    DGV_kelUser.Columns["password"].DisplayIndex = 2;
                    DGV_kelUser.Columns["no_telp"].DisplayIndex = 3;
                    DGV_kelUser.Columns["btnEditCol"].DisplayIndex = 4;
                    DGV_kelUser.Columns["btnHapusCol"].DisplayIndex = 5;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data user: " + ex.Message);
            }
        }

        private void UserSummary()
        {
            try
            {
                CONTROLLERS.c_KelolaUser controllerUser = new CONTROLLERS.c_KelolaUser();
                int totalUser = controllerUser.UserSummary();
                lblUser.Text = totalUser.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat ringkasan user: " + ex.Message);
            }
        }



        private void btnDashboardAdmin_Click(object sender, EventArgs e)
        {

        }

        private void DGV_kelUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idTerpilih = Convert.ToInt32(DGV_kelUser.Rows[e.RowIndex].Cells["id_akun"].Value);
                string usernameTerpilih = DGV_kelUser.Rows[e.RowIndex].Cells["username"].Value.ToString();

                string noTelpTerpilih = DGV_kelUser.Rows[e.RowIndex].Cells["no_telp"].Value.ToString();

                if (DGV_kelUser.Columns[e.ColumnIndex].Name == "btnHapusCol" || DGV_kelUser.Columns[e.ColumnIndex].HeaderText == "Aksi2")
                {
                    DialogResult konfirmasi = MessageBox.Show($"Apakah Anda yakin ingin menghapus akun '{usernameTerpilih}' secara permanen?",
                        "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (konfirmasi == DialogResult.Yes)
                    {
                        try
                        {
                            CONTROLLERS.c_KelolaUser controllerUser = new CONTROLLERS.c_KelolaUser();

                            bool isHapusBerhasil = controllerUser.HapusUser(idTerpilih);

                            if (isHapusBerhasil)
                            {
                                MessageBox.Show($"Akun '{usernameTerpilih}' berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TampilkanDataUser(); 
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (DGV_kelUser.Columns[e.ColumnIndex].Name == "btnEditCol" || DGV_kelUser.Columns[e.ColumnIndex].HeaderText == "Aksi")
                {
                    VIEWS.EditAkun popUp = new VIEWS.EditAkun();

                    popUp.IdAkunTerpilih = idTerpilih;
                    popUp.txtEditUsername.Text = usernameTerpilih;
                    popUp.txtEditNotelp.Text = noTelpTerpilih;
                    popUp.txtEditPass.Text = ""; 

                    if (popUp.ShowDialog() == DialogResult.OK)
                    {
                        TampilkanDataUser();
                    }
                }
            }
        }

        private void btnTambahAkun_Click(object sender, EventArgs e)
        {
            VIEWS.TambahUser popUp = new VIEWS.TambahUser();

            if (popUp.ShowDialog() == DialogResult.OK)
            {
                CONTROLLERS.c_KelolaUser controllerUser = new CONTROLLERS.c_KelolaUser();
                DGV_kelUser.DataSource = controllerUser.GetAllAkun();
            }

        }

        private void txtEditUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void PbEdit_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PbEdit_Click_1(object sender, EventArgs e)
        {

        }

        private void txtEditUsername_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnkelolaUser_Click(object sender, EventArgs e)
        {

        }

        private void KelolaUser_Load(object sender, EventArgs e)
        {

        }

        private void btnKelolaPupuk_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaPupuk kelolapForm = new projek_PBOSQL.VIEWS.KelolaPupuk();
            kelolapForm.Show();
            this.Hide();
        }

        private void btnKelolaTahapan_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaTahapan kelolatForm = new projek_PBOSQL.VIEWS.KelolaTahapan();
            kelolatForm.Show();
            this.Hide();
        }

        private void btnHistori_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.ADMIN Admin = new projek_PBOSQL.VIEWS.ADMIN();
            Admin.Show();
            this.Hide();
        }

        private void btnKelolaPupuk_Click_1(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaPupuk kelolaPupuk = new projek_PBOSQL.VIEWS.KelolaPupuk();
            kelolaPupuk.Show();
            this.Hide();
        }

        private void btnKelolaStock_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaStock kelolaStock = new projek_PBOSQL.VIEWS.KelolaStock();
            kelolaStock.Show();
            this.Hide();
        }

        private void btnKelolaTahapan_Click_1(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaTahapan kelolatahapForm = new projek_PBOSQL.VIEWS.KelolaTahapan();
            kelolatahapForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                projek_PBOSQL.VIEWS.ROLE Logout = new projek_PBOSQL.VIEWS.ROLE();
                Logout.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }
    }

}
