using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Text;

namespace projek_PBOSQL.MODELS.Pengguna
{
    public class Admin : User
    {
        public Admin(string Pass, string Username, string Role) : base(Pass, Username, Role)
        {

        }
    }
}
