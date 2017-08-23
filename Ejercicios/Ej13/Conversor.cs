using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej13
{
    public class Conversor
    {
        static string DecimaABinario(double nro)
        {
            return nro.ToString();
        }

        static double BinarioADecimal(string binario)
        {
            return Convert.ToDouble(binario);
        }
    }
}
