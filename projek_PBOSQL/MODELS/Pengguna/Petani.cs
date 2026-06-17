using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.MODELS.Pengguna
{
    public class Petani : User
    {
        public Petani(int id_akun, string Pass, string Username, string Role, bool canUsePetaniMode) : base(id_akun, Pass, Username, Role, canUsePetaniMode)
        {

        }
    }
}
