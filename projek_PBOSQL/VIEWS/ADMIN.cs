using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using projek_PBOSQL.CONTROLLERS;


namespace projek_PBOSQL.VIEWS
{
    public partial class ADMIN : Form
    {
        private readonly c_Dashboard _dash = new c_Dashboard();
        public ADMIN()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                DataTable dtAktivitas = _dash.GetTransaksi();

                dgvAktivitasTerbaru.DataSource = null;
                dgvAktivitasTerbaru.DataSource = dtAktivitas;

                if (dgvAktivitasTerbaru.Columns["waktu"] != null)
                    dgvAktivitasTerbaru.Columns["waktu"].HeaderText = "Waktu Transaksi";

                if (dgvAktivitasTerbaru.Columns["nama_petani"] != null)
                    dgvAktivitasTerbaru.Columns["nama_petani"].HeaderText = "Nama Petani";

                if (dgvAktivitasTerbaru.Columns["jenis_pupuk"] != null)
                    dgvAktivitasTerbaru.Columns["jenis_pupuk"].HeaderText = "Jenis Pupuk";

                if (dgvAktivitasTerbaru.Columns["jumlah"] != null)
                    dgvAktivitasTerbaru.Columns["jumlah"].HeaderText = "Jumlah (Kg)";

                if (dgvAktivitasTerbaru.Columns["total"] != null)
                    dgvAktivitasTerbaru.Columns["total"].HeaderText = "Total Biaya (Rp)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDashboardAdmin_Click(object sender, EventArgs e)
        {

        }

        private void ADMIN_Load(object sender, EventArgs e)
        {
            UpdateTotalTransaksi();
            UpdateTotalStockPupuk();
            UpdateTotalJenisPupuk();
        }

        private void UpdateTotalTransaksi()
        {
            try
            {
                CONTROLLERS.c_Dashboard totalTransaksi = new CONTROLLERS.c_Dashboard();
                long jumlah = totalTransaksi.ttltransaksi();
                lblTotalTransaksi.Text = jumlah.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat total transaksi: " + ex.Message);
            }
        }

        private void UpdateTotalStockPupuk()
        {
            try
            {
                CONTROLLERS.c_Dashboard totalStockPupuk = new CONTROLLERS.c_Dashboard();
                long jumlah = totalStockPupuk.ttlStokPupuk(); 
                lblTotalStokPupuk.Text = jumlah.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat total stok: " + ex.Message);
            }
        }

        private void UpdateTotalJenisPupuk()
        {
            try
            {
                CONTROLLERS.c_Dashboard totalJenisPupuk = new CONTROLLERS.c_Dashboard();
                long jumlah = totalJenisPupuk.ttlJenisPupuk(); 
                lblTotalJenisPupuk.Text = jumlah.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat total stok: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaUser kelolauserForm = new projek_PBOSQL.VIEWS.KelolaUser();
            kelolauserForm.Show();
            this.Hide();
        }

        private void btnkelolaPupuk_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaPupuk kelolapupukForm = new projek_PBOSQL.VIEWS.KelolaPupuk();
            kelolapupukForm.Show();
            this.Hide();
        }

        private void btnkelolaTahapan_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaTahapan kelolaTahapanForm = new projek_PBOSQL.VIEWS.KelolaTahapan();
            kelolaTahapanForm.Show();
            this.Hide();
        }

        private void btnhistoriTransaksi_Click(object sender, EventArgs e)
        {

        }

        private void panelSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKelolaStock_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaStock stock = new projek_PBOSQL.VIEWS.KelolaStock();
            stock.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaPupuk kelolaPupuk = new projek_PBOSQL.VIEWS.KelolaPupuk();
            kelolaPupuk.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaUser kelolauserForm = new projek_PBOSQL.VIEWS.KelolaUser();
            kelolauserForm.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaStock kelolaStock = new projek_PBOSQL.VIEWS.KelolaStock();
            kelolaStock.Show();
            this.Hide();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaTahapan kelolaTahapan = new projek_PBOSQL.VIEWS.KelolaTahapan();
            kelolaTahapan.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Anda yakin ingin keluar?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
