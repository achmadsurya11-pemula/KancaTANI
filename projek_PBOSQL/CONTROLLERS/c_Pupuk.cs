using System;
using System.Collections.Generic;
using System.Text;
using projek_PBOSQL.Interface;
using projek_PBOSQL.MODELS;

namespace projek_PBOSQL.CONTROLLERS
{
    internal class c_Pupuk : ICPupuk
    {
        private readonly PupukContext _pupukContext = new PupukContext();

        public List<Pupuk> GetAllPupuk(bool includeInactive = false)
        {
            return _pupukContext.GetAllPupuk(includeInactive);
        }

        public bool TambahPupuk(string nama_pupuk, double HargaKg)
        {
            return _pupukContext.TambahPupuk(nama_pupuk, HargaKg);
        }

        public bool HapusPupuk(int id_pupuk)
        {
            return _pupukContext.HapusPupuk(id_pupuk);
        }

        public bool UpdatePupuk(int id_pupuk, string nama_pupuk, double HargaKg)
        {
            return _pupukContext.UpdatePupuk(id_pupuk, nama_pupuk, HargaKg);
        }

        public (double totalStok, int totalJenis) LabelRingkasan()
        {
            return _pupukContext.LabelRingkasan();
        }
    }
}
