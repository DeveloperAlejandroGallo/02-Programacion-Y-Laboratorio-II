using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_4
{
    class Clase_4
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumador2 = new Sumador();
            
            Console.WriteLine("La 1° suma da: {0}", sumador.Sumar(2, 3));
            Console.WriteLine("La 1° suma da: {0}", sumador2.Sumar(10, 100));
            Console.WriteLine("La 2° suma da: {0}", sumador.Sumar("10", "3"));

            Console.WriteLine("La cantidad de sumas es: {0}", sumador.getCantidadSumas());

            Console.WriteLine("La cantidad de sumas es: {0}", (long)sumador);

            Console.WriteLine("La suma de la cant de sumas de sumador 1 y 2 es: {0}", sumador + sumador2);

            Console.WriteLine("La cant de sumas de ambos es igual?: {0}", sumador | sumador2);


            Console.ReadKey();
        }
    }
}
