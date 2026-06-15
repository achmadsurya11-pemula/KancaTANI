using Npgsql;
using projek_PBOSQL.HELPERS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Npgsql;
using projek_PBOSQL.HELPERS;

namespace projek_PBOSQL.MODELS
{
    internal class DashboardContext
    {
        private string connstring = "Host=localhost;Username=postgres;Password=1111;Database=KancaTani";
        public DataTable GetTransaksi()
        {
            int idLog = UserSession.IdAkunAktif;
            var dt = new DataTable();

            // 🌟 PERBAIKAN 1: Sesuaikan nama view dengan SQL-mu (v_historyTansaksi)
            string query = "SELECT * FROM v_historyTansaksi WHERE id_akun = @idAkun";

            try
            {
                using (var conn = ConnectDB.GetConn())
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    // 🌟 PERBAIKAN 2: Wajib masukkan parameter ke command agar query tahu siapa yang login
                    cmd.Parameters.AddWithValue("@idAkun", idLog);

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil aktivitas terbaru: " + ex.Message);
            }
            return dt;
        }

        public long ttltransaksi()
        {
            long total = 0;
            string query = "select count(*) from transaksi";

            using (NpgsqlConnection conn = new NpgsqlConnection(connstring))
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        object? result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            total = Convert.ToInt64(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            return total;
        }

        public long ttlStokPupuk()
        {
            long totalStok = 0;
            string query = "Select * from v_totalstock";

            using (NpgsqlConnection conn = new NpgsqlConnection(connstring))
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        object? result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            totalStok = Convert.ToInt64(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error hitung stok: " + ex.Message);
                    }
                }
            }
            return totalStok;
        }
        public long ttlJenisPupuk()
        {
            long totalJenis = 0;
            string query = "SELECT COUNT(*) FROM pupuk WHERE status = 'Aktif'";

            using (NpgsqlConnection conn = new NpgsqlConnection(connstring))
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        object? result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {

                            totalJenis = Convert.ToInt64(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error hitung stok: " + ex.Message);
                    }
                }
            }
            return totalJenis;
        }
    }
}
