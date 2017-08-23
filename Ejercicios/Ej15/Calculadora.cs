using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej15
{
    public class Calculadora
    {
        static public double Calcular(double nro1, double nro2, string operador)
        {
            double result = 0;

            switch (operador)
            {
                case "+":
                    result = nro1 + nro2;
                    break;
                case "-":
                    result = nro1 - nro2;
                    break;
                case "*":
                    result = nro1 * nro2;
                    break;
                case "/":
                    if (Validar(nro2))
                        result = nro1 / nro2;
                    else
                    {
                        result = 0;
                        Console.WriteLine("ERROR EL DIVISOR NO PUEDE SER 0.");
                    }
                    break;
                default:
                    break;
            }



            return result;
        }


        private static bool Validar(double nro)
        {
            return nro != 0;
        }

        public static void Mostrar(double resultado)
        {
            Console.WriteLine("\nEl Resultado es: {0}", resultado);
        }

    }
}
