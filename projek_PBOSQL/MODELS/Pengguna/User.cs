using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.MODELS.Pengguna
{
    public class User
    {
        private bool _CanUsePetaniMode;
        private int id_akun;
        private string username;
        private string password;
        private string role;

        public string Pass { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public string Role { get => role; set => role = value; }
        public int IDAkun { get => id_akun; set => id_akun = value; }
        public bool CanUsePetaniMode { get => _CanUsePetaniMode; set => _CanUsePetaniMode = value; }

        protected User(int Id_akun, string Pass, string Username, string Role, bool canUsePetaniMode)
        {
            id_akun = Id_akun;
            password = Pass;
            username = Username;
            role = Role;
            CanUsePetaniMode = canUsePetaniMode;
        }
    }
}
