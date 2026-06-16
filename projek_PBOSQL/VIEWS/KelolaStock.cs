using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using projek_PBOSQL.CONTROLLERS;
using projek_PBOSQL.MODELS;
using projek_PBOSQL.Interface;


namespace projek_PBOSQL.VIEWS
{
    public partial class KelolaStock : Form
    {
        private readonly c_Stock _stockcontext = new c_Stock();
        public KelolaStock()
        {
            InitializeComponent();
            TampilkanDataPupuk();
            MuatRingkasanCard();
        }

        private void TampilkanDataPupuk()
        {
            try
            {
                var daftarPupuk = _stockcontext.GetAllStock();
                dgvPupuk.DataSource = null;
                dgvPupuk.Columns.Clear();

                dgvPupuk.DataSource = daftarPupuk;

                if (dgvPupuk.Columns.Count > 0)
                {
                    dgvPupuk.Columns["nama_pupuk"].HeaderText = "Nama Pupuk";
                    dgvPupuk.Columns["Stock"].HeaderText = "Stok (Kg)";
                    dgvPupuk.Columns["HargaKg"].HeaderText = "Harga Per Kg";

                    // Menyembunyikan kolom ID atau status 
                    if (dgvPupuk.Columns["id_pupuk"] != null) dgvPupuk.Columns["id_pupuk"].Visible = false;
                    if (dgvPupuk.Columns["status"] != null) dgvPupuk.Columns["status"].Visible = false;
                    if (dgvPupuk.Columns["gambar"] != null) dgvPupuk.Columns["gambar"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void MuatRingkasanCard()
        {
            try
            {
                var summary = _stockcontext.LabelRingkasan();
                lblTotalStock.Text = $"{summary.totalStok:N0} Kg";
                lblPeringatan.Text = $"{summary.stockRendah} Jenis";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat info ringkasan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahStock formPopUp = new TambahStock();

            if (formPopUp.ShowDialog() == DialogResult.OK)
            {
                TampilkanDataPupuk();
            }
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {
            DetailRestock restock = new DetailRestock();
            restock.Show();
        }


        private void button3_Click(object sender, EventArgs e)
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

        private void btndash_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.ADMIN admin = new projek_PBOSQL.VIEWS.ADMIN();
            admin.Show();
            this.Hide();
        }

        private void btnKel_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaUser KelolaUser = new projek_PBOSQL.VIEWS.KelolaUser();
            KelolaUser.Show();
            this.Hide();
        }

        private void btnKelPuk_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaPupuk KelolaPupuk = new projek_PBOSQL.VIEWS.KelolaPupuk();
            KelolaPupuk.Show();
            this.Hide();
        }

        private void btnKelTah_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaTahapan KelolaTahapan = new projek_PBOSQL.VIEWS.KelolaTahapan();
            KelolaTahapan.Show();
            this.Hide();
        }

        private void lblPeringatan_Click(object sender, EventArgs e)
        {

        }

        private void txtCariStok_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string kataKunci = txtCariStok.Text.Trim();

                List<Pupuk> hasilPencarian = _stockcontext.CariStokPupuk(kataKunci);

                dgvPupuk.DataSource = null; 
                dgvPupuk.DataSource = hasilPencarian; 

                if (dgvPupuk.Columns["id_pupuk"] != null)
                {
                    dgvPupuk.Columns["id_pupuk"].Visible = false;
                }

                if (dgvPupuk.Columns["status"] != null)
                {
                    dgvPupuk.Columns["status"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal melakukan pencarian: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
