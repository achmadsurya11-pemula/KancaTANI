using projek_PBOSQL.CONTROLLERS;
using projek_PBOSQL.MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using projek_PBOSQL.CONTROLLERS;

namespace projek_PBOSQL.VIEWS
{
    public partial class KelolaTahapan : Form
    {
        private readonly c_KelolaTahapan _kelolatahapanContext = new c_KelolaTahapan();
        public KelolaTahapan()
        {
            InitializeComponent();
            TampilkanDataTahapan();
        }

        private void TampilkanDataTahapan()
        {
            dgvTahapan.Rows.Clear();

            var daftarTahapan = _kelolatahapanContext.GetAllTahapan();

            foreach (var tahapan in daftarTahapan)
            {

                int rowIndex = dgvTahapan.Rows.Add(tahapan.id_fase,tahapan.nama_fase,tahapan.umur_min_hst,tahapan.umur_max_hst,tahapan.nama_tanaman);
                DataGridViewRow row = dgvTahapan.Rows[rowIndex];
                row.Tag = tahapan;
            }
        }

        private void btnkelolaTahapan_Click(object sender, EventArgs e)
        {

        }

        private void btnhistoriTransaksi_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelMainContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KelolaTahapan_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.ADMIN admin = new projek_PBOSQL.VIEWS.ADMIN();
            admin.Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaUser kelolauser = new projek_PBOSQL.VIEWS.KelolaUser();
            kelolauser.Show();
            this.Hide();
        }

        private void btnKelolaPupuk_Click_1(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaPupuk kelolapupuk = new projek_PBOSQL.VIEWS.KelolaPupuk();
            kelolapupuk.Show();
            this.Hide();
        }

        private void btnKelolaStock_Click_1(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaStock kelolastock = new projek_PBOSQL.VIEWS.KelolaStock();
            kelolastock.Show();
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
    }
}
