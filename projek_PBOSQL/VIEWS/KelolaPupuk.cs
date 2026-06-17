using projek_PBOSQL.CONTROLLERS;
using projek_PBOSQL.MODELS;
using projek_PBOSQL.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projek_PBOSQL.VIEWS
{
    public partial class KelolaPupuk : Form
    {
        private readonly c_Pupuk _pupukController = new c_Pupuk();
        public KelolaPupuk()
        {
            InitializeComponent();
            TampilkanDataPupuk();
            MuatRingkasanCard();
        }

        private void TampilkanDataPupuk()
        {
            dgvPupuk.Rows.Clear();


            var daftarPupuk = _pupukController.GetAllPupuk(chkTampilkanSemua.Checked);

            foreach (var pupuk in daftarPupuk)
            {

                int rowIndex = dgvPupuk.Rows.Add(pupuk.id_pupuk, pupuk.nama_pupuk, pupuk.status);
                DataGridViewRow row = dgvPupuk.Rows[rowIndex];
                row.Tag = pupuk;

                if (pupuk.status == "Tidak Aktif")
                {
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
                }
                else
                {
                    row.DefaultCellStyle.ForeColor = dgvPupuk.ForeColor;
                }
            }
        }
        private void MuatRingkasanCard()
        {
            try
            {
                var summary = _pupukController.LabelRingkasan();
                lblTotalStock.Text = $"{summary.totalStok:N0} Kg";
                lblJenisPupuk.Text = $"{summary.totalJenis} Jenis";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat info ringkasan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormKelolaPupuk_Load(object sender, EventArgs e)
        {
            TampilkanDataPupuk();
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.ADMIN admin = new projek_PBOSQL.VIEWS.ADMIN();
            admin.Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaUser kelolauserForm = new projek_PBOSQL.VIEWS.KelolaUser();
            kelolauserForm.Show();
            this.Hide();
        }

        private void chkTampilkanSemua_CheckedChanged(object sender, EventArgs e)
        {
            TampilkanDataPupuk();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.TambahPupuk addpupuk = new projek_PBOSQL.VIEWS.TambahPupuk();
            if (addpupuk.ShowDialog() == DialogResult.OK)
            {
                TampilkanDataPupuk();
            }
            addpupuk.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPupuk.CurrentRow == null || dgvPupuk.CurrentRow.Index < 0)
            {
                MessageBox.Show("Pilih data pupuk yang ingin diUpdate terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); //
                return;
            }

            var pupukTerpilih = (Pupuk)dgvPupuk.CurrentRow.Tag;

            if (pupukTerpilih != null)
            {
                int id_pupuk = pupukTerpilih.id_pupuk;
                string nama_pupuk = pupukTerpilih.nama_pupuk;
                double HargaKg = pupukTerpilih.HargaKg;

                TambahPupuk formPopUpEdit = new TambahPupuk(id_pupuk, nama_pupuk, HargaKg);

                if (formPopUpEdit.ShowDialog() == DialogResult.OK)
                {
                    TampilkanDataPupuk();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPupuk.CurrentRow == null)
            {
                MessageBox.Show("Pilih data pupuk yang ingin dihapus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idPupukSelected = Convert.ToInt32(dgvPupuk.CurrentRow.Cells[0].Value);
            string namaPupukSelected = dgvPupuk.CurrentRow.Cells[1].Value.ToString();

            DialogResult konfirmasi = MessageBox.Show($"Apakah Anda yakin ingin menghapus (menonaktifkan) {namaPupukSelected}?",
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    bool sukses = _pupukController.HapusPupuk(idPupukSelected);

                    if (sukses)
                    {
                        MessageBox.Show("Pupuk berhasil dinonaktifkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TampilkanDataPupuk();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.ROLE role = new projek_PBOSQL.VIEWS.ROLE();
            role.Show();
            this.Hide();
        }

        private void btnKelolaStock_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaStock stock = new projek_PBOSQL.VIEWS.KelolaStock();
            stock.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKelolaPupuk_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaPupuk pupuk = new projek_PBOSQL.VIEWS.KelolaPupuk();
            pupuk.Show();
            this.Hide();
        }

        private void btnKelolaTahapan_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaTahapan tahapan = new projek_PBOSQL.VIEWS.KelolaTahapan();
            tahapan.Show();
            this.Hide();
        }

        private void dgvPupuk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
