using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej13;

namespace Clase5
{
    class Clase5
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 5";
            NumeroBinario bin1 = new NumeroBinario("11101000101001");
            NumeroDecimal dec1 = new NumeroDecimal(256);

            NumeroBinario bin2;
            NumeroDecimal dec2;

            Console.WriteLine("Nro Binario 1: {0}", bin1.getNro());
            Console.WriteLine("Nro Decimal 1: {0}", dec1.getNro());
            Console.WriteLine("Bin + Dec {0}", bin1 + dec1);
            Console.WriteLine("Dec + Bin {0}", dec1 + bin1);
            Console.WriteLine("Bin - Dec {0}", bin1 - dec1);
            Console.WriteLine("Dec - Bin {0}", dec1 - bin1);
            Console.WriteLine("Bin == Dec {0}", bin1 == dec1);
            Console.WriteLine("Dec == Bin {0}", dec1 == bin1);
            Console.WriteLine("Bin != Dec {0}", bin1 != dec1);
            Console.WriteLine("Dec != Bin {0}", dec1 != bin1);

            Console.WriteLine("NumeroBinario objBinario = 1001: {0}", bin2 = "1001");
            Console.WriteLine("NumeroDecimal objDecimal = 9: {0}", dec2 = 9);

            Console.WriteLine("Nro Binario 2: {0}", bin2.getNro());
            Console.WriteLine("Nro Decimal 2: {0}", dec2.getNro());

            Console.WriteLine("(string)objBinario: {0}", (string)bin2 );
            Console.WriteLine("(double)objDecimal: {0}", (double)dec2);

            Console.ReadKey();
        }
    }
}
