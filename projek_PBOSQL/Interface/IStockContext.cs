using projek_PBOSQL.MODELS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace projek_PBOSQL.Interface
{
    public interface IStockContext
    {
        List<Pupuk> GetAllStock();
        public List<Pupuk> CariStokPupuk(string kataKunci);
        public bool TambahPengadaan(int jumlahKg, double hargaBeli, int idPupuk, int idSupplier);
        public DataTable GetDetailRestockDataTable();
        public (double totalStok, int stockRendah) LabelRingkasan();
    }
}

