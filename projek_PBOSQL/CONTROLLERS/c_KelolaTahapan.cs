using projek_PBOSQL.MODELS;
using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.CONTROLLERS
{
    internal class c_KelolaTahapan
    {
        private readonly KelolaTahapanContext _kelolatahapanContext = new KelolaTahapanContext();

        public List<KelolaTahapan> GetAllTahapan()
        {
            return _kelolatahapanContext.GetAllTahapan();
        }
    }
}
