using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";
                       
            int nro, suma=0, max=0, min=0;
            bool primero=true;

            for(var i=0; i < 5; i++)
            {
                Console.Write("Ingrese un Número: ");
                if(int.TryParse(Console.ReadLine(),out nro))
                {
                    if(primero)
                    {
                        min = nro;
                        max = nro;
                        primero = false;
                    }

                    if (nro > max)
                        max = nro;

                    if (nro < min)
                        min = nro;

                    suma += nro;
                }
                else
                {
                    Console.WriteLine("Número inválido, vuelva a ingresarlo.");
                    i--;
                }

            }

            Console.WriteLine("El Máximo es: {0}\nEl Mínimo es: {1}\nEl Promedio es: {2}", max, min, suma/5);

            Console.ReadKey();


        }
    }
}
