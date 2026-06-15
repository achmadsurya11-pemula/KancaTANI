
using Npgsql;
using projek_PBOSQL.HELPERS;
using projek_PBOSQL.MODELS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace projek_PBOSQL.CONTROLLERS
{
    internal class c_KelolaUser
    {
        private readonly UserContext _userContext = new UserContext();

        public bool TambahUser(string username, string password, string noTelp, string idRoleString, bool canUsePetaniMode)
        {
            return _userContext.TambahUser(username, password, noTelp, idRoleString, canUsePetaniMode);
        }

        public DataTable GetAllAkun()
        {
            return _userContext.GetAllAkun();
        }

        public bool HapusUser(int idAkun)
        {
            return _userContext.HapusUser(idAkun);
        }

        public bool EditUser(int idAkun, string username, string password, string noTelp, string idRoleString)
        {
            return _userContext.EditUser(idAkun, username, password, noTelp);
        }

        public int UserSummary()
        {
            return _userContext.UserSummary();
        }
    }
}
