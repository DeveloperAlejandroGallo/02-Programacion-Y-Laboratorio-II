using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej06
{
    class Ejercicio06
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 06";

            int anio;

            Console.Write("Ingrese un año: ");
            if (int.TryParse(Console.ReadLine(), out anio))
            {
                if (esBisiesto(anio))
                {
                    Console.WriteLine("El año {0} es Bisiesto", anio);
                }
                else
                {
                    Console.WriteLine("El año {0} NO es Bisiesto", anio);
                }
            }
            else
                Console.WriteLine("Debe ingresar un nro válido.");

            Console.ReadKey();
        }

        static bool esBisiesto(int anio)
        {
            bool result = false;

            if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 4 == 0 && anio % 100 == 0 && anio % 400 == 0))
                result = true;

            return result;
        }
    }
}
