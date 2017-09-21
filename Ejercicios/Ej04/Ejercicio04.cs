using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 04. Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) 
 * que son divisores del número.
El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6. 
 * Escribir una aplicación que encuentre los 4 primeros números perfectos. 
 * Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%)
 */
namespace Ej04
{
    class Ejercicio04
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej 04 - Numero Perfecto";

            int cantNrosPerfectos = 4, contador=0, nro=0;

            Console.WriteLine("LOS PRIMEROS 4 NROS PERFECTOS SON: ");
            while(contador < cantNrosPerfectos)
            {
                nro++;//Empiezo de 0 por eso primero lo incremento para comenzar con 1.
                if (esPerfecto(nro))
                { 
                    contador++;
                    Console.WriteLine("{0}° Nro Perfecto: {1}",contador,nro);
                }
                
            }


            Console.ReadKey();
        }

        static bool esPerfecto(int nro)
        {
            bool result = false;
            int sumador = 0;

            for (var i = nro - 1; i >= 1; i-- )
            {
                if(i>0)
                { 
                    if(nro % i == 0)
                    {
                        sumador += i;
                    }
                }
            }

            if (sumador == nro)
                result = true;

            return result;
        }

    }
}
