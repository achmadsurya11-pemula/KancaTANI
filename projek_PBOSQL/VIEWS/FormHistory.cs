using projek_PBOSQL.MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projek_PBOSQL.VIEWS
{
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();
            LoadHistoryBelanjaPetani();
        }

        private void LoadHistoryBelanjaPetani()
        {
            try
            {
                var historypetani = new UserContext();

                DataTable dt = historypetani.GetTransaksiByPetani();

                dgvHistory.DataSource = dt;

                dgvHistory.Columns["waktu"].HeaderText = "Tanggal Transaksi";
                dgvHistory.Columns["jenis_pupuk"].HeaderText = "Nama Pupuk";
                dgvHistory.Columns["jumlah"].HeaderText = "Jumlah (Kg)";
                dgvHistory.Columns["total"].HeaderText = "Total Bayar";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Tampilan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.FormTransaksi beli = new projek_PBOSQL.VIEWS.FormTransaksi();
            beli.Show();
            this.Hide();
        }

        private void btnAnalisa_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.PETANI analisa = new projek_PBOSQL.VIEWS.PETANI();
            analisa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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
