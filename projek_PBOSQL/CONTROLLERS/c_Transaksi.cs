using System;
using System.Collections.Generic;
using System.Text;
using projek_PBOSQL.MODELS;

namespace projek_PBOSQL.CONTROLLERS
{
    internal class c_Transaksi
    {
        private readonly TransaksiContext _transaksiContext = new TransaksiContext();
        public bool ValidasiDanSimpan(int id_akun, int id_toko, List<DetailTransaksi> daftarBelanja)
        {
            // Validasi 
            if (daftarBelanja == null || daftarBelanja.Count == 0)
            {
                throw new Exception("Gagal Checkout! Keranjang belanja kosong.");
            }

            if (id_toko <= 0)
            {
                throw new Exception("Silakan pilih cabang toko terlebih dahulu!");
            }

            // dilanjutkan ke lapisan model data
            return _transaksiContext.EksekusiTransaksiProsedur(id_akun, id_toko, daftarBelanja);
        }
    }
}
