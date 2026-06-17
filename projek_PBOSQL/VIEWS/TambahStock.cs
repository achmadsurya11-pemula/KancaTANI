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
    public partial class TambahStock : Form
    {
        private readonly c_Stock _stockController = new c_Stock();
        private readonly c_Pupuk _pupukController = new c_Pupuk();
        public TambahStock()
        {
            InitializeComponent();
            LoadComboBoxData();
        }

        private void LoadComboBoxData()
        {
            try
            {
                var daftarPupuk = _pupukController.GetAllPupuk(false); 
                cbPupuk.DataSource = daftarPupuk;
                cbPupuk.DisplayMember = "nama_pupuk"; 
                cbPupuk.ValueMember = "id_pupuk";     

                var daftarSupplier = _stockController.GetStaticSuppliers();
                cbSupplier.DataSource = daftarSupplier;
                cbSupplier.DisplayMember = "nama_supplier";
                cbSupplier.ValueMember = "id_supplier";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data pilihan ComboBox: " + ex.Message);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cbPupuk.SelectedValue == null || cbSupplier.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtJumlah.Text) || string.IsNullOrWhiteSpace(txtHarga.Text))
            {
                MessageBox.Show("Semua kolom input wajib diisi/dipilih!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtJumlah.Text, out int jumlahKg) || !double.TryParse(txtHarga.Text, out double hargaBeli))
            {
                MessageBox.Show("Jumlah KG dan Harga Beli harus berupa angka valid!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int idPupukSelected = Convert.ToInt32(cbPupuk.SelectedValue);
                int idSupplierSelected = Convert.ToInt32(cbSupplier.SelectedValue);

                bool sukses = _stockController.TambahPengadaan(jumlahKg, hargaBeli, idPupukSelected, idSupplierSelected);

                if (sukses)
                {
                    MessageBox.Show("Pengadaan stok berhasil disimpan, Stok Pupuk otomatis bertambah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; 
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gagal Menyimpan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
