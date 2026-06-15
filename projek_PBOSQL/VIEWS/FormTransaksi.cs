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
    public partial class FormTransaksi : Form
    {
        private readonly c_Transaksi _transactionController = new c_Transaksi();
        private readonly StockContext _stockContext = new StockContext();

        // Memori Penyimpanan Keranjang Belanja menggunakan Objek List terstruktur
        private List<DetailTransaksi> _keranjangBelanja = new List<DetailTransaksi>();

        // Dictionary untuk menyimpan relasi ID Pupuk dan Nama Pupuk untuk visualisasi DataGridView
        private Dictionary<int, string> _namaPupukDict = new Dictionary<int, string>();

        public FormTransaksi()
        {
            InitializeComponent();
            LoadKatalogDanToko();
            cmbMetodePembayaran.SelectedIndex = 0;
        }
        public FormTransaksi(List<DetailTransaksi> rekomendasiAnalisis)
        {
            InitializeComponent();
            LoadKatalogDanToko();

            // Ambil data rekomendasi dari memori RAM analisis, dimasukan langsung ke keranjang belanja
            _keranjangBelanja = rekomendasiAnalisis;
            RefreshDataGridViewKeranjang();
        }

        private void LoadKatalogDanToko()
        {
            LoadKatalogProdukUC();
            LoadDataTokoComboBox();
        }

        // Memuat dari User Control ke dalam FlowLayoutPanel
        private void LoadKatalogProdukUC()
        {
            flpKatalog.Controls.Clear();
            _namaPupukDict.Clear();

            // Mengambil seluruh data pupuk yang ada di database
            List<Pupuk> daftarPupuk = _stockContext.GetAllStock();

            foreach (var pupuk in daftarPupuk)
            {
                int idPupuk = pupuk.id_pupuk;

                if (!_namaPupukDict.ContainsKey(idPupuk))
                    _namaPupukDict.Add(idPupuk, pupuk.nama_pupuk);

                // Instansiasi objek User Control
                UC_ItemPupuk cardProduk = new UC_ItemPupuk();
                cardProduk.SetDataProduk(idPupuk, pupuk.nama_pupuk, pupuk.HargaKg, pupuk.Stock);

                cardProduk.OnTambahKlik = (id, nama, harga, qty) =>
                {
                    TambahKeKeranjangMemori(id, harga, qty);
                };
                flpKatalog.Controls.Add(cardProduk);
            }
        }
        private void TambahKeKeranjangMemori(int idPupuk, double hargaKg, int qty)
        {
            MessageBox.Show($"Sinyal Masuk! ID: {idPupuk}, Qty: {qty}");
            // Cek apakah produk tersebut sudah pernah dimasukkan ke keranjang sebelumnya
            var itemAda = _keranjangBelanja.FirstOrDefault(x => x.id_pupuk == idPupuk);

            if (itemAda != null)
            {
                // Jika pupuk sudah ditambahkan lanjutkan denggan + quantity
                itemAda.quantity += qty;
                itemAda.totalHarga = itemAda.quantity * hargaKg;
            }
            else
            {
                // Jika belum ada, buat baris objek DetailTransaksi baru
                DetailTransaksi detailBaru = new DetailTransaksi
                {
                    id_pupuk = idPupuk,
                    quantity = qty,
                    totalHarga = qty * hargaKg
                };
                _keranjangBelanja.Add(detailBaru);
            }
            RefreshDataGridViewKeranjang();
        }
        private void RefreshDataGridViewKeranjang()
        {
            // Proyeksi LINQ untuk menampilkan nama teks pupuk di gridview berdasarkan IdPupuk-nya
            dgvKeranjang.DataSource = null;
            dgvKeranjang.DataSource = _keranjangBelanja.Select(x => new
            {
                NamaProduk = _namaPupukDict.ContainsKey(x.id_pupuk) ? _namaPupukDict[x.id_pupuk] : "Pupuk Terpilih",
                JumlahKg = x.quantity,
                Subtotal = x.totalHarga
            }).ToList();

            HitungTotalAkhir();
        }

        private void HitungTotalAkhir()
        {
            double total = _keranjangBelanja.Sum(x => x.totalHarga);
            lblTotalHarga.Text = "Total: Rp " + total.ToString("N0");
        }

        private void LoadDataTokoComboBox()
        {
            // Pengisian ComboBox Toko dari DB (id_toko dan nama_toko)
            Dictionary<int, string> comboSource = new Dictionary<int, string>
            {
                { 1, "KancaTani Cabang Pusat" },
            };
            cmbToko.DataSource = new BindingSource(comboSource, null);
            cmbToko.DisplayMember = "Value";
            cmbToko.ValueMember = "Key";
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            int idAkunSaatIni = UserSession.IdAkunAktif;

            // Cek darurat: kalau ID-nya 0
            if (idAkunSaatIni == 0)
            {
                MessageBox.Show("Error: ID Sesi Pengguna tidak terbaca (Bernilai 0). Periksa Controller Login Anda!", "Error Internal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_keranjangBelanja == null || _keranjangBelanja.Count == 0)
            {
                MessageBox.Show("Gagal Checkout! Keranjang belanja masih kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idTokoTerpilih = Convert.ToInt32(cmbToko.SelectedValue);
                string inputKasir = txtInputPembayaran.Text.Trim();

                // Hitung total belanjaan
                double totalBelanjaSaya = 0;
                foreach (var item in _keranjangBelanja)
                {
                    totalBelanjaSaya += item.totalHarga;
                }

                // =============================================================
                // 🌟 SEKTOR VALIDASI BARU: txtInputPembayaran (Taruh Di Sini!)
                // =============================================================
                string metodePilihan = cmbMetodePembayaran.SelectedItem?.ToString() ?? "Tunai";

                // A. Cek jika input masih kosong melompong
                if (string.IsNullOrWhiteSpace(inputKasir))
                {
                    string pesan = metodePilihan == "Tunai"
                        ? "Silakan masukkan jumlah uang pembayaran tunai!"
                        : "Silakan masukkan nomor resi bukti transfer!";
                    MessageBox.Show(pesan, "Validasi Pembayaran", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInputPembayaran.Focus();
                    return;
                }

                // B. Cek spesifik jika metodenya "Tunai"
                if (metodePilihan == "Tunai")
                {
                    // 1. Harus berupa angka bulat (tidak boleh kemasukan huruf)
                    if (!int.TryParse(inputKasir, out int jumlahUang))
                    {
                        MessageBox.Show("Jumlah uang tunai harus berupa angka bulat bersih (tanpa titik, koma, atau huruf)!", "Format Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtInputPembayaran.Focus();
                        return;
                    }

                    // 2. Jumlah uang tidak boleh kurang dari total belanjaan
                    if (jumlahUang < totalBelanjaSaya)
                    {
                        double kurangnya = totalBelanjaSaya - jumlahUang;
                        MessageBox.Show($"Uang tunai kurang Rp {kurangnya:N0}! Transaksi tidak dapat dilanjutkan.", "Uang Tidak Cukup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtInputPembayaran.Focus();
                        return;
                    }
                }
                else // C. Cek spesifik jika metodenya "Transfer"
                {
                    // Batasi panjang nomor resi agar tidak merusak kolom database (misal max 50 karakter)
                    if (inputKasir.Length > 50)
                    {
                        MessageBox.Show("Nomor resi transfer terlalu panjang! Maksimal 50 karakter.", "Format Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtInputPembayaran.Focus();
                        return;
                    }
                }
                // =============================================================

                // Deklarasikan Objek Induk Abstrak
                CONTROLLERS.MetodePembayaran eksekutor = null;

                // Polymorphism
                if (metodePilihan == "Tunai")
                {
                    eksekutor = new CONTROLLERS.PembayaranTunai();
                }
                else
                {
                    eksekutor = new CONTROLLERS.PembayaranTransfer();
                }

                if (eksekutor != null)
                {
                    // Mengirim data aman yang sudah lolos sensor validasi di atas
                    bool sukses = eksekutor.ProsesPembayaran(totalBelanjaSaya, _keranjangBelanja, inputKasir, idAkunSaatIni, idTokoTerpilih);

                    if (sukses)
                    {
                        _keranjangBelanja.Clear();
                        RefreshDataGridViewKeranjang();
                        LoadKatalogProdukUC();
                        txtInputPembayaran.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Transaksi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {

        }

        private void btnAnalisa_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.PETANI analisa = new projek_PBOSQL.VIEWS.PETANI();
            analisa.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.FormHistory history = new projek_PBOSQL.VIEWS.FormHistory();
            history.Show();
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
