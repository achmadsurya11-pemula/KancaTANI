using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.MODELS.Pengguna
{
    internal class KelolaUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string NoTelp { get; set; }
        public string Role { get; set; }

        public KelolaUser(string username, string password, string noTelp, string role)
        {
            Username = username;
            Password = password;
            NoTelp = noTelp;
            Role = role;
        }
    }
}
