using Npgsql;
using projek_PBOSQL.HELPERS;
using projek_PBOSQL.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace projek_PBOSQL.MODELS
{
    internal class PupukContext
    {
        public List<Pupuk> GetAllPupuk(bool includeInactive = false)
        {
            List<Pupuk> list = new List<Pupuk>();

            string query = @"SELECT id_pupuk, nama_pupuk, status
                     FROM pupuk 
                     WHERE (@includeAll = TRUE OR status = 'Aktif')
                     ORDER BY id_pupuk ASC";
            try
            {
                using (var conn = ConnectDB.GetConn())
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@includeAll", includeInactive);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pupuk pupuk = new Pupuk
                            {
                                id_pupuk = reader.GetInt32(reader.GetOrdinal("id_pupuk")),
                                nama_pupuk = reader.GetString(reader.GetOrdinal("nama_pupuk")),
                                status = reader.GetString(reader.GetOrdinal("status"))
                            };
                            list.Add(pupuk);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil data pupuk: " + ex.Message);
            }
            return list;
        }

        public bool TambahPupuk(string nama_pupuk, double HargaKg)
        {
            string query = "CALL sp_tambah_pupuk_dan_stok(@nama, @harga)";

            try
            {
                using (var conn = ConnectDB.GetConn())
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", nama_pupuk);
                    cmd.Parameters.AddWithValue("@harga", HargaKg);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menambah pupuk via Stored Procedure: " + ex.Message);
            }
        }

        public bool HapusPupuk(int id_pupuk)
        {
            string query = "CALL sp_soft_delete_pupuk(@id)";

            try
            {
                using (var conn = ConnectDB.GetConn())
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id_pupuk);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menonaktifkan pupuk via Stored Procedure: " + ex.Message);
            }
        }

        public bool UpdatePupuk(int id_pupuk, string nama_pupuk, double HargaKg)
        {
            string query = "SELECT fn_update_pupuk_dan_stok(@id, @nama, @harga)";

            try
            {
                using (var conn = ConnectDB.GetConn())
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id_pupuk);
                    cmd.Parameters.AddWithValue("@nama", nama_pupuk);
                    cmd.Parameters.AddWithValue("@harga", HargaKg);

                    // Mengambil hasil return scalar (true/false) 
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToBoolean(result);
                    }

                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengupdate data via Function: " + ex.Message);
            }
        }

        

        public (double totalStok, int totalJenis) LabelRingkasan()
        {
            double totalStok = 0;
            int totalJenis = 0;

            string qTotalStok = @"Select * from v_totalstock";

            string qTotalJenis = "SELECT COUNT(*) FROM pupuk WHERE status = 'Aktif'";

            try
            {
                using (var conn = ConnectDB.GetConn())
                {
                    using (var cmd = new NpgsqlCommand(qTotalStok, conn))
                    {
                        totalStok = Convert.ToDouble(cmd.ExecuteScalar());
                    }

                    using (var cmd = new NpgsqlCommand(qTotalJenis, conn))
                    {
                        totalJenis = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memuat ringkasan card pupuk: " + ex.Message);
            }

            return (totalStok, totalJenis);
        }
    }
}
