using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej12
{
    class Ejercicio12
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio12";
            int sumador=0, nro;
            Console.WriteLine("INGRESO DE NROS:");
            do
            {
                //Console.Clear();
                Console.Write("\nNúmero: ");
                if(int.TryParse(Console.ReadLine(), out nro))
                {
                    sumador += nro;
                }
                else
                {
                    Console.WriteLine("\nEL VALOR INGRESADO NO ES UN NRO");
                    continue;
                }
            } while (ValidarRespuesta.ValidaS_N());

            Console.WriteLine("\nLa suma total es: {0}",sumador);

            Console.ReadKey();
        }
    }
}
