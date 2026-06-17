using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using projek_PBOSQL.MODELS;

namespace projek_PBOSQL.VIEWS
{
    public partial class UC_ItemPupuk : UserControl
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int id_pupuk { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string nama_pupuk { get; set; } = string.Empty; 

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double HargaKg { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Action<int, string, double, int>? OnTambahKlik { get; set; }
        public UC_ItemPupuk()
        {
            InitializeComponent();
        }

        public void SetDataProduk(int id, string nama, double harga, int stok, string namaFileGambar)
        {
            id_pupuk = id;
            nama_pupuk = nama;
            HargaKg = harga;

            lblNama.Text = nama;
            lblHarga.Text = "Rp " + harga.ToString("N0") + " /Kg";
            lblStok.Text = "Stok: " + stok + " Kg";

            if (string.IsNullOrEmpty(namaFileGambar)) namaFileGambar = "default.png";
            string pathGambar = System.IO.Path.Combine(Application.StartupPath, "Images", namaFileGambar);

            if (System.IO.File.Exists(pathGambar))
            {
                pgGambar.ImageLocation = pathGambar; 
            }
            else
            {
                pgGambar.ImageLocation = System.IO.Path.Combine(Application.StartupPath, "Images", "default.png");
            }

            nudQty.Maximum = stok == 0 ? 1 : stok;
            if (stok == 0)
            {
                lblStok.Text = "STOK HABIS!";
                btnTambah.Enabled = false;
                nudQty.Enabled = false;
            }
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            int jumlahBeli = Convert.ToInt32(nudQty.Value);

            OnTambahKlik?.Invoke(id_pupuk, nama_pupuk, HargaKg, jumlahBeli);

            nudQty.Value = 1;
        }
    }
}
