using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Text;

namespace projek_PBOSQL.MODELS.Pengguna
{
    public class Admin : User
    {
        public Admin(int id_akun, string Pass, string Username, string Role) : base(id_akun, Pass, Username, Role)
        {

        }
    }
}
