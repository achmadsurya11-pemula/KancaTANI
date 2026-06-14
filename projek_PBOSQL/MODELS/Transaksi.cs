using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.MODELS
{
    public class Transaksi
    {
        public int id_transaksi { get; set; }
        public DateTime crreated { get; set; }
        public int id_akun { get; set; }
        public int id_toko { get; set; }
    }
}
