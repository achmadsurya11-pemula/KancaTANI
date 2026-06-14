using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Npgsql;
using projek_PBOSQL.HELPERS;

namespace projek_PBOSQL.MODELS
{
    public class AnalisaContext
    {
        public List<Tanaman> GetAllTanaman()
        {
            var list = new List<Tanaman>();
            string query = "SELECT id_tanaman, nama_tanaman FROM tanaman ORDER BY nama_tanaman ASC";

            try
            {
                using (var conn = ConnectDB.GetConn())
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Tanaman
                        {
                            id_tanaman = Convert.ToInt32(reader["id_tanaman"]),
                            nama_tanaman = reader["nama_tanaman"]?.ToString() ?? ""
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil data tanaman: " + ex.Message);
            }
            return list;
        }

        public DataTable GetRekomendasiTabel(int idTanaman, double luas, string fase)
        {
            var dt = new DataTable();
            string query = @"
                            SELECT id_pupuk,
                            fase_pemupukan AS ""Fase Pemupukan"",
                            waktu_pemupukan AS ""Waktu Rekomendasi"",
                            nama_pupuk AS ""Jenis Pupuk"",
                            ROUND((dosis_per_m2 * @luas)::numeric, 2) AS ""Kebutuhan (Kg)"",
                            ROUND((dosis_per_m2 * @luas * harga_satuan)::numeric, 0) AS ""Estimasi Biaya (Rp)""
                            FROM v_rekomendasi_dasar
                            WHERE id_tanaman = @idTanaman 
                            AND (LOWER(TRIM(@fase)) = 'semua fase' OR LOWER(TRIM(fase_pemupukan)) = LOWER(TRIM(@fase)))";
            try
            {
                using (var conn = ConnectDB.GetConn())
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@luas", luas);
                    cmd.Parameters.AddWithValue("@idTanaman", idTanaman);
                    cmd.Parameters.AddWithValue("@fase", fase);

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memproses query rekomendasi: " + ex.Message);
            }
            return dt;
        }
    }
}
