using System;
using System.Collections.Generic;
using System.Text;
using projek_PBOSQL.MODELS;

namespace projek_PBOSQL.CONTROLLERS
{
    public class PembayaranTransfer : MetodePembayaran
    {
        private readonly c_Transaksi _transaksiController = new c_Transaksi();

        public override bool ProsesPembayaran(double totalHarga, List<DetailTransaksi> keranjang, string inputTambahan, int idAkun, int idToko)
        {
            // 1. Validasi nomor resi transfer
            if (string.IsNullOrWhiteSpace(inputTambahan) || inputTambahan.Length < 5)
            {
                MessageBox.Show("Pembayaran Gagal! Masukkan Nomor Resi Transfer yang valid.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                // 🔥 KUNCI UTAMA: Memanggil method asli database milikmu di sini
                bool apakahSuksesDatabase = _transaksiController.ValidasiDanSimpan(idAkun, idToko, keranjang);

                if (apakahSuksesDatabase)
                {
                    // Tampilkan nota resi jika database berhasil disimpan
                    VIEWS.FormResi nota = new VIEWS.FormResi(totalHarga, 0, "Transfer", inputTambahan, keranjang);
                    nota.ShowDialog();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memproses transaksi: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
