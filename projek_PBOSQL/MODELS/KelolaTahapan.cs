using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.MODELS
{
    public class KelolaTahapan
    {
        public int id_fase {  get; set; }
        public string nama_fase { get; set; }
        public int umur_min_hst { get; set; }
        public int umur_max_hst { get; set; }
        public string nama_tanaman { get; set; }
    }
}
