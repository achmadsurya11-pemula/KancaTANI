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
    public partial class DetailRestock : Form
    {
        private readonly c_Stock _stockcontext = new c_Stock();
        public DetailRestock()
        {
            InitializeComponent();
            LoadDataRestock();
        }

        private void LoadDataRestock()
        {
            try
            {
                DataTable dtRestock = _stockcontext.GetDetailRestockDataTable();
                dgvDetail.DataSource = dtRestock;

                
                if (dgvDetail.Columns.Count > 0)
                {
                    dgvDetail.Columns["created"].HeaderText = "Tanggal Restock";
                    dgvDetail.Columns["jumlah_kg"].HeaderText = "Jumlah (Kg)";
                    dgvDetail.Columns["harga_beli"].HeaderText = "Total Harga Beli";
                    dgvDetail.Columns["nama_pupuk"].HeaderText = "Jenis Pupuk";
                    dgvDetail.Columns["nama_supplier"].HeaderText = "Supplier";

                    dgvDetail.Columns["harga_beli"].DefaultCellStyle.Format = "N0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
