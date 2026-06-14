using Npgsql;
using projek_PBOSQL.HELPERS;
using projek_PBOSQL.MODELS.Pengguna;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace projek_PBOSQL.MODELS
{
    internal class UserContext
    {
        private string connstring = "Host=localhost;Username=postgres;Password=1111;Database=KancaTani";

        public User AmbilDataLogin(string username, string password)
        {
            string query = "SELECT username, password, id_role, nama_role FROM v_login_akun WHERE username = @username AND password = @password";

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
                            int id_role = Convert.ToInt32(reader["id_role"]);
                            string uName = reader["username"]?.ToString() ?? "";
                            string pass = reader["password"]?.ToString() ?? "";
                            string roleText = reader["nama_role"]?.ToString() ?? "petani";

                            // Mengembalikan objek konkrit berdasarkan id_role
                            if (id_role == 1)
                            {
                                return new Admin(pass, uName, roleText);
                            }
                            else
                            {
                                return new Petani(pass, uName, roleText);
                            }
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

        public bool TambahUser(string username, string password, string noTelp, string idRoleString)
        {
            bool status = false;
            NpgsqlConnection conn = ConnectDB.GetConn();

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "INSERT INTO akun (username, password, no_telp, id_role) VALUES (@username, @password, @no_telp, @id_role)";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@no_telp", noTelp);

                int idRoleInteger = int.Parse(idRoleString);
                cmd.Parameters.AddWithValue("@id_role", idRoleInteger);

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

        public bool EditUser(int idAkun, string username, string password, string noTelp)
        {
            bool status = false;
            string query = "SELECT sp_edit_akun(@id, @username, @password, @no_telp)";

            try
            {
                NpgsqlConnection conn = ConnectDB.GetConn();

                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open(); 
                }
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

                    // Ambil return BOOLEAN dari fungsi PostgreSQL
                    status = (bool)cmd.ExecuteScalar();
                }
                conn.Close();
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
