using Npgsql;
using projek_PBOSQL.HELPERS;
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.MODELS
{
    internal class StockContext
    {
        public List<Pupuk> GetAllStock()
        {
            List<Pupuk> list = new List<Pupuk>();

            string query = @"SELECT * from v_Getpupukstock";
            try
            {
                using (var conn = ConnectDB.GetConn())
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pupuk p = new Pupuk();
                            p.id_pupuk = Convert.ToInt32(reader["id_pupuk"]);

                            p.nama_pupuk = reader["nama_pupuk"].ToString();
                            p.Stock = Convert.ToInt32(reader["stock"]);
                            p.HargaKg = Convert.ToDouble(reader["harga_kg"]);

                            list.Add(p);
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

        public List<Pupuk> GetAllStock(string kataKunci)
        {
            List<Pupuk> list = new List<Pupuk>();

            string query = @"SELECT * FROM v_allpupukstock 
                             WHERE LOWER(nama_pupuk) LIKE LOWER(@keyword)";
            try
            {
                using (var conn = ConnectDB.GetConn())
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    // menambahkan % agar pencarian bersifat fleksibel (mengandung kata tersebut)
                    cmd.Parameters.AddWithValue("@keyword", "%" + kataKunci + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pupuk pupuk = new Pupuk
                            {
                                nama_pupuk = reader.GetString(reader.GetOrdinal("nama_pupuk")),
                                Stock = reader.GetInt32(reader.GetOrdinal("stock")),
                                HargaKg = reader.GetDouble(reader.GetOrdinal("harga_kg"))
                            };
                            list.Add(pupuk);
                        }
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Gagal mencari data pupuk: " + ex.Message); }
            return list;
        }

        public bool TambahPengadaan(int jumlahKg, double hargaBeli, int idPupuk, int idSupplier)
        {
            string query = "CALL sp_tambah_pengadaan_stock(@jumlah, @harga, @idPupuk, @idSupplier)";

            try
            {
                using (var conn = ConnectDB.GetConn())
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@jumlah", jumlahKg);
                    cmd.Parameters.AddWithValue("@harga", hargaBeli);
                    cmd.Parameters.AddWithValue("@idPupuk", idPupuk);
                    cmd.Parameters.AddWithValue("@idSupplier", idSupplier);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database Error (TambahPengadaan): " + ex.Message);
            }
        }

        public DataTable GetDetailRestockDataTable()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * from v_detailRestock 
                            ORDER BY created DESC";
            try
            {
                using (var conn = ConnectDB.GetConn())
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memuat view detail restock: " + ex.Message);
            }
            return dt;
        }

        public (double totalStok, int stockRendah) LabelRingkasan()
        {
            double totalStok = 0;
            int stockRendah = 0;

            string TotalStok = @"Select * from v_totalstock";

            string StockRendah = "Select * from v_stockRendah";

            try
            {
                using (var conn = ConnectDB.GetConn())
                {
                    using (var cmd = new NpgsqlCommand(TotalStok, conn))
                    {
                        totalStok = Convert.ToDouble(cmd.ExecuteScalar());
                    }

                    using (var cmd = new NpgsqlCommand(StockRendah, conn))
                    {
                        stockRendah = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memuat ringkasan card pupuk: " + ex.Message);
            }
            return (totalStok, stockRendah);
        }
    }
}
