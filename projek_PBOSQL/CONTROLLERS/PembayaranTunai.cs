using System;
using System.Collections.Generic;
using System.Text;
using projek_PBOSQL.MODELS;

namespace projek_PBOSQL.CONTROLLERS
{
    public class PembayaranTunai : MetodePembayaran
    {
        private readonly c_Transaksi _transaksiController = new c_Transaksi();

        public override bool ProsesPembayaran(double totalHarga, List<DetailTransaksi> keranjang, string inputTambahan, int idAkun, int idToko)
        {
            // 1. Validasi nominal uang tunai
            if (!double.TryParse(inputTambahan, out double uangDibayar) || uangDibayar < totalHarga)
            {
                MessageBox.Show("Pembayaran Gagal! Uang tunai kurang atau format salah.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                bool apakahSuksesDatabase = _transaksiController.ValidasiDanSimpan(idAkun, idToko, keranjang);

                if (apakahSuksesDatabase)
                {
                    // menampilkan nota resi dan transaksi berhasil disimpan
                    VIEWS.FormResi nota = new VIEWS.FormResi(totalHarga, uangDibayar, "Tunai", "", keranjang);
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
