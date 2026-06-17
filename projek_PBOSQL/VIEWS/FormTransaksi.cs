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
        private readonly PupukContext _pupukContext = new PupukContext();

        
        private List<DetailTransaksi> _keranjangBelanja = new List<DetailTransaksi>();

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

            _keranjangBelanja = rekomendasiAnalisis;
            RefreshDataGridViewKeranjang();
        }

        private void LoadKatalogDanToko()
        {
            LoadKatalogProdukUC();
            LoadDataTokoComboBox();
        }

        private void LoadKatalogProdukUC()
        {
            flpKatalog.Controls.Clear();
            _namaPupukDict.Clear();

            System.Data.DataTable dtPupuk = _stockContext.AmbilDataKatalogUC();

            foreach (System.Data.DataRow row in dtPupuk.Rows)
            {
                int idPupuk = Convert.ToInt32(row["id_pupuk"]);
                string namaPupuk = row["nama_pupuk"].ToString();
                double harga = Convert.ToDouble(row["harga_kg"]); 
                int stok = Convert.ToInt32(row["stock"]);        
                string namaGambar = row["gambar"].ToString(); 

                if (!_namaPupukDict.ContainsKey(idPupuk))
                    _namaPupukDict.Add(idPupuk, namaPupuk);

                UC_ItemPupuk cardProduk = new UC_ItemPupuk();

                cardProduk.SetDataProduk(idPupuk, namaPupuk, harga, stok, namaGambar);

                cardProduk.OnTambahKlik = (id, nama, harga, qty) =>
                {
                    TambahKeKeranjangMemori(id, harga, qty);
                };
                flpKatalog.Controls.Add(cardProduk);
            }
        }
        private void TambahKeKeranjangMemori(int idPupuk, double hargaKg, int qty)
        {
            var itemAda = _keranjangBelanja.FirstOrDefault(x => x.id_pupuk == idPupuk);

            if (itemAda != null)
            {
                itemAda.quantity += qty;
                itemAda.totalHarga = itemAda.quantity * hargaKg;
            }
            else
            {
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

                double totalBelanjaSaya = 0;
                foreach (var item in _keranjangBelanja)
                {
                    totalBelanjaSaya += item.totalHarga;
                }

                string metodePilihan = cmbMetodePembayaran.SelectedItem?.ToString() ?? "Tunai";

                if (string.IsNullOrWhiteSpace(inputKasir))
                {
                    string pesan = metodePilihan == "Tunai"
                        ? "Silakan masukkan jumlah uang pembayaran tunai!"
                        : "Silakan masukkan jumlah sesuai dengan total dengan pas!";
                    MessageBox.Show(pesan, "Validasi Pembayaran", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInputPembayaran.Focus();
                    return;
                }

                if (metodePilihan == "Tunai")
                {
                    if (!int.TryParse(inputKasir, out int jumlahUang))
                    {
                        MessageBox.Show("Jumlah uang tunai harus berupa angka bulat bersih (tanpa titik, koma, atau huruf)!", "Format Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtInputPembayaran.Focus();
                        return;
                    }

                    if (jumlahUang < totalBelanjaSaya)
                    {
                        double kurangnya = totalBelanjaSaya - jumlahUang;
                        MessageBox.Show($"Uang tunai kurang Rp {kurangnya:N0}! Transaksi tidak dapat dilanjutkan.", "Uang Tidak Cukup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtInputPembayaran.Focus();
                        return;
                    }
                }
                else 
                {
                    if (!double.TryParse(inputKasir, out double nominalTransfer))
                    {
                        MessageBox.Show("Nominal Transfer harus berupa angka!", "Format Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (nominalTransfer != totalBelanjaSaya)
                    {
                        MessageBox.Show("Nominal Transfer harus sesuai dengan Total Belanja (Rp " + totalBelanjaSaya.ToString("N0") + ")",
                                        "Input Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Hentikan proses agar tidak lanjut ke transaksi
                    }
                }

                CONTROLLERS.MetodePembayaran eksekutor = null;

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
