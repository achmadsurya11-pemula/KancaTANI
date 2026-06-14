using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.MODELS
{
    public class Pupuk
    {
        public int id_pupuk { get; set; }
        public string nama_pupuk { get; set; }
        public string status {  get; set; }
        public int Stock { get; set; }
        public double HargaKg { get; set; }
        
    }
}
