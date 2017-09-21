using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 03. Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
 */

namespace Ej03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 03";

            int nroFinal;
            Console.Write("Ingrese un número: ");
            if (int.TryParse(Console.ReadLine(), out nroFinal))
            {
                for(var i=1; i<=nroFinal;i++)
                {
                    if(esPrimo(i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
                Console.WriteLine("Debe ingresar un nro valido");

            Console.ReadKey();
        }


        static bool esPrimo(int nro)
        {
            bool result=true;

            for (var i = nro-1; i > 1; i-- )
            {
                if(nro % i == 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

    }
}
