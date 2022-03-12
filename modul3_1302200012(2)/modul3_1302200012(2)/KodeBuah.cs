using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302200012_2_
{
    internal class KodeBuah
    {
        public enum buah
        {
            Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry,
            Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka
        };

        public String getKodeBuah(buah Buah)
        {
            String[] arrayKode = { "A00", "B00", "C00", "D00", "E00",
                "F00", "H00",
                "I00", "J00", "K00", "L00", "M00", "N00", "O00"};


            return arrayKode[(int)Buah];
        }
    }
}
