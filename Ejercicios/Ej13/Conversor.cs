using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej13
{
    public class Conversor
    {
        public static string DecimalABinario(double nro)
        {
            string aux="",ret="";
            int resultado=0;

            aux = (nro % 2).ToString();
            resultado = (int)(nro / 2); 

            while(resultado >= 2)
            {
                aux += (resultado % 2).ToString();
                resultado = (int)(resultado / 2);
               
            }
            aux += resultado;
            for (var i = aux.Length - 1; i >= 0; i-- )
            {
                ret += aux[i];
            }

            return ret;
        }

        public static double BinarioADecimal(string binario)
        {
            double suma=0;
            for (var i = 0; i < binario.Length; i++ )
            {
                if (binario[i] == '1')
                    suma += Math.Pow(2, (double)((binario.Length-1)-i));
            }

            return suma;
        }

        public static bool EsBinario(string binario, out string bin)
        {
            bool ret = true;
            bin = binario;
            for (var i = 0; i < binario.Length; i++)
                if (binario[i] != '0' && binario[i] != '1')
                {
                    ret = false;
                    bin = "";
                    break;
                }

            return ret;
        }
    }
}
