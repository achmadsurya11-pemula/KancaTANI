using Npgsql;
using projek_PBOSQL.HELPERS;
using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.MODELS
{
    public class TransaksiContext
    {
        private string connstring = "Host=localhost;Username=postgres;Password=1111;Database=KancaTani";
        public bool EksekusiTransaksiProsedur(int id_akun, int id_toko, List<DetailTransaksi> keranjang)
        {
            // Memecah data List keranjang menjadi bentuk Array 
            int[] arrIdPupuk = new int[keranjang.Count];
            int[] arrQty = new int[keranjang.Count];

            decimal[] arrTotal = new decimal[keranjang.Count];

            for (int i = 0; i < keranjang.Count; i++)
            {
                arrIdPupuk[i] = keranjang[i].id_pupuk;
                arrQty[i] = keranjang[i].quantity;
                arrTotal[i] = Convert.ToDecimal(keranjang[i].totalHarga);
            }

            try
            {
                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("CALL insert_transaksi_kancatani(@p_id_akun, @p_id_toko, @p_id_pupuk, @p_quantity, @p_total_harga)", conn))
                    {
                        cmd.Parameters.AddWithValue("@p_id_akun", id_akun);
                        cmd.Parameters.AddWithValue("@p_id_toko", id_toko);
                        cmd.Parameters.AddWithValue("@p_id_pupuk", arrIdPupuk);
                        cmd.Parameters.AddWithValue("@p_quantity", arrQty);
                        cmd.Parameters.AddWithValue("@p_total_harga", arrTotal);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

}
