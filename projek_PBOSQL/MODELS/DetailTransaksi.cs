using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.MODELS
{
    public class DetailTransaksi
    {
        public int id_detail { get; set; }
        public int quantity { get; set; }
        public double totalHarga { get; set; }
        public int id_transaksi { get; set; }
        public int id_pupuk { get; set; }
    }
}
