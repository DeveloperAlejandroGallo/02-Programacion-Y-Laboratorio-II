using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej11
{
    class Ejercicio11
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Ejercicio Nro 11";
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;

            int nro, contador=0, suma=0, max=0, min=0;
            bool primeraVez = true;
            Console.Clear();
        
            do
            {
                Console.Write("Ingrese el {0}° Nro: ", contador+1);
                if(int.TryParse(Console.ReadLine(), out nro))
                {
                    if(Validacion.Validar(100,-100,nro))
                    {
                        suma += nro;
                        contador++;
                        if(primeraVez)
                        {
                            max = nro;
                            min = nro;
                            primeraVez = false;
                        }

                        if(nro > max)
                            max = nro;

                        if(nro < min)
                            min = nro;


                    }
                    else
                    {
                        Console.WriteLine("El nro ingresado no es válido!");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("LO INGRESADO NO ES NUMERICO");
                    continue;
                }

            } while (contador < 10 );

            Console.WriteLine("MINIMO: {0}\nMAXIMO: {1}\nSUMA: {2}\nPROMEDIO: {3:#,###.00}", min, max, suma, (suma / contador));
            Console.ReadKey();
        }
    }
}
