using projek_PBOSQL.Interface;
using projek_PBOSQL.MODELS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace projek_PBOSQL.CONTROLLERS
{
    internal class c_Stock : IStockContext
    {
        private readonly StockContext _stockcontext = new StockContext();

        public List<Pupuk> GetAllStock()
        {
            return _stockcontext.GetAllStock();
        }

        public List<Pupuk> CariStokPupuk(string kataKunci)
        {
            if (string.IsNullOrWhiteSpace(kataKunci))
            {
                return _stockcontext.GetAllStock(); // Memanggil versi default
            }

            // Overloard
            return _stockcontext.GetAllStock(kataKunci);
        }

        public List<Supplier> GetStaticSuppliers()
        {
            return new List<Supplier>
            {
                new Supplier { id_supplier = 1, nama_supplier = "Agro Suci" },
                new Supplier { id_supplier = 2, nama_supplier = "Agro TM" }
            };
        }

        public DataTable GetDetailRestockDataTable()
        {
            return _stockcontext.GetDetailRestockDataTable();
        }

        public bool TambahPengadaan(int jumlahKg, double hargaBeli, int idPupuk, int idSupplier)
        {
            //Validasi Pengadaan tidak boleh bernilai 0 atau minus
            if (jumlahKg <= 0)
                throw new Exception("Jumlah KG pengadaan harus lebih dari 0!");

            if (hargaBeli <= 0)
                throw new Exception("Harga beli harus lebih dari 0!");

            return _stockcontext.TambahPengadaan(jumlahKg, hargaBeli, idPupuk, idSupplier);
        }

        public (double totalStok, int stockRendah) LabelRingkasan()
        {
            return _stockcontext.LabelRingkasan();
        }
    }
}
