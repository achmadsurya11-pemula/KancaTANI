
using System;
using System.Collections.Generic;
using System.Text;
using projek_PBOSQL.MODELS;
using System.Data;

namespace projek_PBOSQL.CONTROLLERS
{
    internal class c_Analisis
    {
        private readonly AnalisaContext _analisaContext = new AnalisaContext();

        public List<Tanaman> GetAllTanaman()
        {
            return _analisaContext.GetAllTanaman();
        }

        public DataTable JalankanAnalisis(int idTanaman, string luasLahanInput, string faseInput)
        {
            if (idTanaman <= 0)
            {
                throw new Exception("Silakan pilih komoditas tanaman terlebih dahulu!");
            }

            if (!double.TryParse(luasLahanInput, out double luasLahan))
            {
                throw new Exception("Input luas lahan harus berupa angka valid!");
            }

            if (string.IsNullOrEmpty(faseInput))
            {
                faseInput = "Semua Fase";
            }

            if (luasLahan <= 0)
            {
                throw new Exception("Luas lahan harus lebih besar dari 0 m²!");
            }
            return _analisaContext.GetRekomendasiTabel(idTanaman, luasLahan, faseInput);
        }
    }
}
