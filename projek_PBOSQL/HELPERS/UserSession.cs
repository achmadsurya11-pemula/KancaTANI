using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL
{
    public static class UserSession
    {
        // Menyimpan id_akun yang sedang aktif login
        public static int IdAkunAktif { get; set; }

        public static string NamaAktif { get; set; }
    }
}
