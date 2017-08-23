using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 05. Un centro numérico es un número que separa una lista de números
enteros (comenzando en 1) en dos grupos de números, cuyas sumas
son iguales.
El primer centro numérico es el 6, el cual separa la lista (1 a
8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas
iguales a 15. El segundo centro numérico es el 35, el cual separa
la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas
son ambas iguales a 595.
Se pide elaborar una aplicación que calcule los centros numéricos
entre 1 y el número que el usuario ingrese por consola.
Nota: Utilizar estructuras repetitivas, selectivas y la función
módulo (%).
 */
namespace Ej05
{
    class Ejercicio05
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 05";

            int nroFinal, i;

            Console.Write("Ingrese un Numero entero: ");
            if (int.TryParse(Console.ReadLine(), out nroFinal))
            {
                for ( i = 1; i <= nroFinal; i++ )
                {
                    if(sumaDesde1ANro(i) == sumaDesdeNroAFinal(i, nroFinal))
                    {
                        Console.WriteLine("El centro numérico es: {0}", i);
                        break;
                    }
                }
                if(i-1==nroFinal)
                    Console.WriteLine("El Nro {0} no posee centro numerico.",nroFinal);
            }
            else
                Console.WriteLine("NO ES UN NRO VÄLIDO");


            Console.ReadKey();

        }

        static int sumaDesde1ANro(int nro)
        {
            int suma = 0;

            for (var i = 1; i < nro; i++)
                suma += i;

            return suma;
        }


        static int sumaDesdeNroAFinal(int nro, int final)
        {
            int suma = 0;

            for (var i = nro+1; i <= final; i++)
                suma += i;

            return suma;
        }

    }
}
