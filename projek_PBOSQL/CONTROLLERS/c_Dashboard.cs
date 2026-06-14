using Npgsql;
using projek_PBOSQL.HELPERS;
using projek_PBOSQL.MODELS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace projek_PBOSQL.CONTROLLERS
{
    internal class c_Dashboard
    {
        private readonly DashboardContext _dash = new DashboardContext();
        public DataTable GetTransaksi()
        {
            return _dash.GetTransaksi();
        }
        public long ttltransaksi()
        {
            return _dash.ttltransaksi();
        }
        public long ttlStokPupuk()
        {
            return _dash.ttlStokPupuk();
        }

        public long ttlJenisPupuk()
        {
            return _dash.ttlJenisPupuk();
        }
    }
}
