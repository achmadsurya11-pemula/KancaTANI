using Npgsql;
using projek_PBOSQL.MODELS; 
using projek_PBOSQL.MODELS.Pengguna;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace projek_PBOSQL.CONTROLLERS
{
    internal class c_users
    {
        private readonly UserContext _userContext = new UserContext();
        public User validasi_login(string Username, string Pass)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Pass))
                {
                    return null;
                }
    
                return _userContext.AmbilDataLogin(Username, Pass);
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal melakukan autentikasi login: " + ex.Message);
            }
        }
    }
}
