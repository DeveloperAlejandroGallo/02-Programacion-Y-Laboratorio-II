using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej10
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;

            Console.WriteLine("Ingrese la altura de la Piramide");
            
            if (int.TryParse(Console.ReadLine(), out altura))
            {
                for (var i = 0; i < altura; i++)
                {
                    for (var j = 0; j < i + 1; j++)
                        Console.Write("*");
                    Console.Write("\n");
                }
            }
            Console.ReadKey();//Pausa
        }
    }
}
