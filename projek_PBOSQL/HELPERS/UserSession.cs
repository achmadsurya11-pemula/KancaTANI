using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL
{
    public static class UserSession
    {
        // Menyimpan ID Akun yang sedang aktif login
        public static int IdAkunAktif { get; set; }

        // Menyimpan Nama Pengguna yang sedang aktif login
        public static string NamaAktif { get; set; }
    }
}
