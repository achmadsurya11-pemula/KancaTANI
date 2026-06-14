using projek_PBOSQL.MODELS;
using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.Interface
{
    public interface ICPupuk
    {
        List<Pupuk> GetAllPupuk(bool includeInactive = false);
        bool TambahPupuk(string nama_pupuk, double HargaKg);

        bool HapusPupuk(int id_pupuk);
        bool UpdatePupuk(int id_pupuk, string nama_pupuk, double HargaKg);
    }
}
