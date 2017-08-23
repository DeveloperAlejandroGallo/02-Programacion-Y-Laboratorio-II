using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej10
{
    class Ejercicio10
    {
        static void Main(string[] args)
        {
            int altura, maxAsteriscos, cantAsterLinea, mitad;

            Console.Title = "Ejercicio 10";

            Console.WriteLine("Ingrese la altura de la Piramide");
            
            if(int.TryParse(Console.ReadLine(), out altura))
            {
                maxAsteriscos = altura + (altura - 1);

                for (var i = 0; i < altura; i++)
                {
                    cantAsterLinea = i + 1 + i;
                    for (var j = 1; j <= maxAsteriscos; j++)
                    {

                        mitad = (maxAsteriscos - cantAsterLinea) / 2;
                        if (j <= mitad || j > mitad + cantAsterLinea)
                        {
                            Console.Write(" ");
                        }

                        if (j > mitad && j <= mitad + cantAsterLinea)
                        {
                            Console.Write("*");
                        }
                    }

                    Console.Write("\n");
                }
            }
            else
                Console.WriteLine("No es un nro valido");

            Console.ReadKey();//Pausa
        }
    }
}
