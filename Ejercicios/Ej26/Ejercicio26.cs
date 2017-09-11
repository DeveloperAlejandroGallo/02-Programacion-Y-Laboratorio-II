using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej26
{
    class Ejercicio26
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 26";

            int[] numeros = new int[20];
            int i=0, nro;

            while(i < 20)
            {
                Console.Write("Ingrese un numero distinto de cero: ");
                
                while(!int.TryParse(Console.ReadLine(), out nro))
                {
                    Console.Write("Ingrese un numero distinto de cero: ");
                }
                if(nro != 0)
                {
                    numeros[i] = nro;
                    i++;
                }

                Console.Clear();
            }

            Console.WriteLine("Los nros ingresados fueron:");

            for(var j=0; j< 20; j++)
            {
                Console.Write(numeros[j] + " - " );
            }


            Console.ReadKey();
            


        }
    }
}
