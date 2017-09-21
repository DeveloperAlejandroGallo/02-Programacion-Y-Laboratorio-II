using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 02. Ingresar un número y mostrar: el cuadrado y el cubo del mismo. 
 * Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. Reingresar número!!!".
Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
 */

namespace Ej02
{
    class Ejercicio02
    {
        static void Main(string[] args)
        {
            int nro;

            Console.Title = "Ejercicio Nro 2";

            Console.Write("Ingrese un Número: ");
            if(int.TryParse(Console.ReadLine(), out nro))
            {
                if(nro > 0)
                {
                    Console.WriteLine("Cuadrado: {0}\nCubo: {1}", Math.Pow(nro, 2), Math.Pow(nro, 3));
                }
                else
                    Console.WriteLine("El nro debe ser mayor a cero");
            }
            Console.ReadKey();
        }
    }
}
