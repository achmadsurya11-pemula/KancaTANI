using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using projek_PBOSQL.CONTROLLERS;
using projek_PBOSQL.MODELS;

namespace projek_PBOSQL.VIEWS
{
    public partial class PETANI : Form
    {
        private readonly c_Analisis _controller = new c_Analisis();
        public PETANI()
        {
            InitializeComponent();
            LoadDataTanamanToComboBox();
            cmbFase.SelectedIndex = 0;
        }

        private void LoadDataTanamanToComboBox()
        {
            try
            {
                var listTanaman = _controller.GetAllTanaman();

                cmbTanaman.DisplayMember = "nama_tanaman";
                cmbTanaman.ValueMember = "id_tanaman";
                cmbTanaman.DataSource = listTanaman;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat daftar tanaman: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HitungTotalBiayaRekomendasi()
        {
            double totalBiaya = 0;

            foreach (DataGridViewRow row in dgvRekomendasi.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["Estimasi Biaya (Rp)"].Value != null)
                {
                    string nilaiString = row.Cells["Estimasi Biaya (Rp)"].Value.ToString();

                    if (double.TryParse(nilaiString, out double hasilKonversi))
                    {
                        totalBiaya += hasilKonversi;
                    }
                }
            }
            lblTotalBiaya.Text = "Total Estimasi Biaya: Rp " + totalBiaya.ToString("N0");
        }
        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.FormTransaksi transaksi = new projek_PBOSQL.VIEWS.FormTransaksi();
            transaksi.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.FormHistory his = new projek_PBOSQL.VIEWS.FormHistory();
            his.Show();
            this.Hide();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTanaman.SelectedValue == null)
                {
                    MessageBox.Show("Silakan pilih komoditas tanaman terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idTanamanTerpilih = Convert.ToInt32(cmbTanaman.SelectedValue);
                string inputLuas = txtLuasLahan.Text.Trim();

                string faseTerpilih = cmbFase.SelectedItem != null ? cmbFase.SelectedItem.ToString().Trim() : "Semua Fase";

                DataTable tabelHasil = _controller.JalankanAnalisis(idTanamanTerpilih, inputLuas, faseTerpilih);

                if (tabelHasil != null && tabelHasil.Rows.Count > 0)
                {
                    // Pasang ke DataGridView
                    dgvRekomendasi.DataSource = tabelHasil;
                    dgvRekomendasi.Columns["id_pupuk"].Visible = false;

                    HitungTotalBiayaRekomendasi();
                }
                else
                {
                    MessageBox.Show("Data rekomendasi tidak ditemukan untuk parameter tersebut.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvRekomendasi.DataSource = null;
                    lblTotalBiaya.Text = "Total Estimasi Biaya: Rp 0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLanjutTransaksi_Click(object sender, EventArgs e)
        {
            if (dgvRekomendasi.Rows.Count == 0 || dgvRekomendasi.DataSource == null)
            {
                MessageBox.Show("Belum ada data rekomendasi. Silakan klik HITUNG terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<DetailTransaksi> listMentah = new List<DetailTransaksi>();

                foreach (DataGridViewRow row in dgvRekomendasi.Rows)
                {
                    if (row.IsNewRow) continue;

                    int ambilIdPupuk = Convert.ToInt32(row.Cells["id_pupuk"].Value);

                    double ambilQtydouble = Convert.ToDouble(row.Cells["Kebutuhan (Kg)"].Value);
                    int ambilQty = Convert.ToInt32(ambilQtydouble);

                    double ambilTotal = Convert.ToDouble(row.Cells["Estimasi Biaya (Rp)"].Value);

                    listMentah.Add(new DetailTransaksi
                    {
                        id_pupuk = ambilIdPupuk,
                        quantity = ambilQty,
                        totalHarga = ambilTotal
                    });
                }

                var keranjangFinal = listMentah
                    .GroupBy(x => x.id_pupuk)
                    .Select(g => new DetailTransaksi
                    {
                        id_pupuk = g.Key,
                        quantity = g.Sum(x => x.quantity),
                        totalHarga = g.Sum(x => x.totalHarga)
                    }).ToList();

                FormTransaksi formKasir = new FormTransaksi(keranjangFinal);
                formKasir.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memproses data untuk transaksi: " + ex.Message, "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
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
    }
}
