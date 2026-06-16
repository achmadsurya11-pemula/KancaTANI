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
    public partial class FormResi : Form
    {
        public FormResi(double total, double bayar, string metode, string resi, List<DetailTransaksi> listBelanja)
        {
            InitializeComponent();

            lblTanggal.Text = "Tanggal : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            lblMetode.Text = "Metode  : " + metode;

            lstItemBelanja.Items.Clear();
            lstItemBelanja.Items.Add("=================================");
            foreach (var item in listBelanja)
            {
                lstItemBelanja.Items.Add($"ID Pupuk: {item.id_pupuk} | Qty: {item.quantity} | Rp {item.totalHarga:N0}");
            }
            lstItemBelanja.Items.Add("=================================");

            lblTotal.Text = "TOTAL        : Rp " + total.ToString("N0");

            if (metode == "Tunai")
            {
                lblBayar.Text = "TUNAI        : Rp " + bayar.ToString("N0");
                lblKembalian.Text = "KEMBALIAN    : Rp " + (bayar - total).ToString("N0");
            }
            else
            {
                lblBayar.Text = " ";
                lblKembalian.Text ="STATUS       : \nPesanan sesuai dapat dilakukan pengambilan Pupuk!";
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTutup_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

