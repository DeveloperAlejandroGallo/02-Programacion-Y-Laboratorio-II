using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej13
{
    class Ejercicio13
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 13";

            int nro;
            string binario;

            Console.Write("Ingrese un nro entero: ");
            while(!int.TryParse(Console.ReadLine(), out nro))
            {
                Console.Write("No es un nro. - Ingrese un nro entero: ");
            }

            Console.WriteLine("El nro {0} convertido a Binario es: {1}", nro, Conversor.DecimalABinario(nro));

            Console.Write("Ingrese un nro Binario: ");
            while (!Conversor.EsBinario(Console.ReadLine(), out binario))
            {
                Console.Write("No es un nro. - Ingrese un nro Binario: ");
            }

            Console.WriteLine("El nro Binario: {0} convertido a Entero es: {1}", binario, Conversor.BinarioADecimal(binario));

            Console.ReadKey();
        }
    }
}
