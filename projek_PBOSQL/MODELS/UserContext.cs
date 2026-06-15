using Npgsql;
using projek_PBOSQL.HELPERS;
using projek_PBOSQL.MODELS.Pengguna;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace projek_PBOSQL.MODELS
{
    internal class UserContext
    {
        private string connstring = "Host=localhost;Username=postgres;Password=1111;Database=KancaTani";

        public User AmbilDataLogin(string username, string password)
        {
            string query = "SELECT id_akun, username, password, id_role, nama_role, can_use_petani_mode FROM v_login_akun WHERE username = @username AND password = @password";
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connstring))
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    conn.Open();
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idAkunDariDB = Convert.ToInt32(reader["id_akun"]);
                            int id_role = Convert.ToInt32(reader["id_role"]);
                            string uName = reader["username"]?.ToString() ?? "";
                            string pass = reader["password"]?.ToString() ?? "";
                            string roleText = reader["nama_role"]?.ToString() ?? "petani";
                            bool bisaModePetani = Convert.ToBoolean(reader["can_use_petani_mode"]);

                            User pengguna;

                            // Mengembalikan objek konkrit berdasarkan id_role
                            if (id_role == 1)
                            {
                                return new Admin(idAkunDariDB,pass, uName, roleText, bisaModePetani);
                            }
                            else
                            {
                                return new Petani(idAkunDariDB, pass, uName, roleText, bisaModePetani);
                            }

                            pengguna.id_akun = idAkunDariDB;

                            return pengguna;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database Error (AmbilDataLogin): " + ex.Message);
            }

            return null; // Mengembalikan null jika tidak ditemukan di DB
        }

        public DataTable GetTransaksiByPetani()
        {
            int idLog = UserSession.IdAkunAktif;
            var dt = new DataTable();

            string query = "SELECT waktu, jenis_pupuk, jumlah, total FROM v_historytransaksi WHERE id_akun = @idAkun";

            try
            {
                using (var conn = ConnectDB.GetConn())
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    // Amankan query menggunakan parameter binding
                    cmd.Parameters.AddWithValue("@idAkun", idLog);

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memuat history belanja Anda: " + ex.Message);
            }
            return dt;
        }
        public DataTable GetAllAkun()
        {
            string query = "SELECT id_akun, username, password, no_telp FROM Akun ORDER BY id_akun";

            using (NpgsqlConnection conn = new NpgsqlConnection(connstring))
            {
                conn.Open();
                using (var adapter = new NpgsqlDataAdapter(query, conn))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        public bool TambahUser(string username, string password, string noTelp, string idRoleString, bool canUsePetaniMode)
        {
            bool status = false;

            if (string.IsNullOrWhiteSpace(noTelp) || !noTelp.All(char.IsDigit))
            {
                throw new ArgumentException("Nomor telepon hanya boleh berisi angka dan tidak boleh kosong!");
            }

            NpgsqlConnection conn = ConnectDB.GetConn();

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "INSERT INTO akun (username, password, no_telp, id_role, can_use_petani_mode) VALUES (@username, @password, @no_telp, @id_role, @can_mode)";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@no_telp", noTelp);

                int idRoleInteger = int.Parse(idRoleString);
                cmd.Parameters.AddWithValue("@id_role", idRoleInteger);

                // 🌟 BIND PARAMETER BOOLEAN BARU
                cmd.Parameters.AddWithValue("@can_mode", canUsePetaniMode);

                int barisTersimpan = cmd.ExecuteNonQuery();
                if (barisTersimpan > 0)
                {
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return status;
        }

        public bool HapusUser(int idAkun)
        {
            bool status = false;
            NpgsqlConnection conn = ConnectDB.GetConn();
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "DELETE FROM akun WHERE id_akun = @id_akun";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_akun", idAkun);
                int barisTerhapus = cmd.ExecuteNonQuery();
                if (barisTerhapus > 0)
                {
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return status;
        }

        public bool EditUser(int idAkun, string username, string noTelp, string password)
        {
            bool status = false;

            if (string.IsNullOrWhiteSpace(noTelp) || !noTelp.All(char.IsDigit))
            {
                throw new ArgumentException("Nomor telepon hanya boleh berisi angka dan tidak boleh kosong!");
            }

            string query = "SELECT sp_edit_akun(@id, @username, @no_telp, @password)";

            try
            {
                using (NpgsqlConnection conn = ConnectDB.GetConn())
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                        conn.Open();
                    else if (conn.State == System.Data.ConnectionState.Broken)
                    {
                        conn.Close();
                        conn.Open();
                    }

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idAkun);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@no_telp", noTelp);
                        cmd.Parameters.AddWithValue("@password", password);

                        status = (bool)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error Database: " + ex.Message);
                status = false;
            }

            return status;
        }

        public int UserSummary()
        {
            int totalUser = 0;
            string Query = @"SELECT COUNT(*) FROM akun";

            try
            {
                using (var conn = ConnectDB.GetConn())
                {
                    using (var cmd = new NpgsqlCommand(Query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            totalUser = Convert.ToInt32(result);
                        }
                    }
                } 
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memuat ringkasan card user: " + ex.Message);
            }
            return totalUser;
        }
    }
}
