using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.MODELS.Pengguna
{
    public class User
    {
        public int id_akun {  get; set; }
        public bool CanUsePetaniMode { get; set; }

        private string username;
        private string password;
        protected string role;

        public string Pass { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public string Role { get => role; set => role = value; }

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
