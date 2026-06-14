using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.MODELS.Pengguna
{
    public class User
    {
        private string username;
        private string password;
        protected string role;

        public string Pass { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public string Role { get => role; set => role = value; }

        protected User(string Pass, string Username, string Role)
        {
            password = Pass;
            username = Username;
            role = Role;
        }
    }
}
