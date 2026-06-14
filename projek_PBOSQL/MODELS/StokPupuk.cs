using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.MODELS
{
    internal class StokPupuk
    {
        public int IdToko { get; set; }
        public int IdPupuk { get; set; }

        private int _stok;
        private decimal _harga;

        public int Stok
        {
            get => _stok;
            set { if (value >= 0) _stok = value; }
        }

        public decimal Harga
        {
            get => _harga;
            set { if (value >= 0) _harga = value; }
        }

        // Validasi ketersediaan stok sebelum transaksi dilakukan (Flow 10)
        public bool ValidasiStokCukup(double kebutuhanKg)
        {
            return _stok >= kebutuhanKg;
        }
    }
}
