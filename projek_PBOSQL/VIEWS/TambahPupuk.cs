using projek_PBOSQL.CONTROLLERS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projek_PBOSQL.VIEWS
{
    public partial class TambahPupuk : Form
    {
        private readonly c_Pupuk _pupukController = new c_Pupuk();
        private bool _isEditMode = false;
        private int _idPupukUntukEdit;

        public TambahPupuk()
        {
            InitializeComponent();
            this.Text = "Tambah Pupuk";
        }

        public TambahPupuk(int id_pupuk, string nama_pupuk, double HargaKg)
        {
            InitializeComponent();

            _isEditMode = true;
            _idPupukUntukEdit = id_pupuk;

            this.Text = "Edit / Ubah Pupuk";
            txtNamaPupuk.Text = nama_pupuk;
            txtHarga.Text = HargaKg.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaPupuk.Text) || string.IsNullOrWhiteSpace(txtHarga.Text))
            {
                MessageBox.Show("Semua kolom input wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtHarga.Text, out double hargaKonversi))
            {
                MessageBox.Show("Input harga harus berupa angka!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool sukses;
                string nama = txtNamaPupuk.Text.Trim();

                if (_isEditMode)
                {
                    sukses = _pupukController.UpdatePupuk(_idPupukUntukEdit, nama, hargaKonversi);
                }
                else
                {
                    sukses = _pupukController.TambahPupuk(nama, hargaKonversi);
                }

                if (sukses)
                {
                    MessageBox.Show("Data berhasil disimpan dan status kembali Aktif!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Memberi tahu Form Utama bahwa aksi sukses
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
