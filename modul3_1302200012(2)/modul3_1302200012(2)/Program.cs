using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302200012_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KodeBuah fruit = new KodeBuah();

            String buahBaru = fruit.getKodeBuah(KodeBuah.buah.Apel);
            Console.WriteLine("Apel -> " + buahBaru);
            //Console.WriteLine("Aprikot -> " + buahBaru);

            Console.WriteLine("\n");
        }
    }
}