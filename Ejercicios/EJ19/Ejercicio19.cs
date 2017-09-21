using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJ19_Boligrafo;

namespace Ej19_Program
{
    class Ejercicio19
    {
        static void Main(string[] args)
        {
            Boligrafo bluePen = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo redPen = new Boligrafo(ConsoleColor.Red, 50);

            Console.WriteLine("El primer boligrafo es: {0} y tiene {1} de tinta", bluePen.getColor(),bluePen.getTinta());
            Console.WriteLine("El segundo boligrafo es: {0} y tiene {1} de tinta", redPen.getColor(),redPen.getTinta());

            Console.ReadKey();


        }
    }
}
