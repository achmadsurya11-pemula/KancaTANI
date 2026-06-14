using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;


namespace projek_PBOSQL.HELPERS
{
    internal class ConnectDB
    {
        //ini inisialisasi database
        private static string connString =
            "Host=localhost;" +
            "Port=5432;" +
            "Username=postgres;" +
            "Password=1111;" + 
            "Database=KancaTani;"; 
        public static NpgsqlConnection GetConn() 
        {
            NpgsqlConnection conn = new NpgsqlConnection(connString);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal di : " + ex.Message);
            }

            return conn;
        }
    }
}


