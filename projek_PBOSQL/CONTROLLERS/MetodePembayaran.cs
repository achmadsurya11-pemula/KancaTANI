using System;
using System.Collections.Generic;
using System.Text;
using projek_PBOSQL.MODELS;

namespace projek_PBOSQL.CONTROLLERS
{
    public abstract class MetodePembayaran
    {
        public abstract bool ProsesPembayaran(double totalHarga, List<DetailTransaksi> keranjang, string inputTambahan, int idAkun, int idToko);
    }
}
