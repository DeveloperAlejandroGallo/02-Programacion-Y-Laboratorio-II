using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej39
{
    class Ejercicio39
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº38 Guía 2017";
            Sobreescrito sobrecarga = new SobreSobreescrito();
            SobreSobreescrito ss = new SobreSobreescrito();
            
            Console.WriteLine("1-\n");
            Console.WriteLine(sobrecarga.ToString());
            string objeto = "¡Este es mi método ToString sobreescrito!";
            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(sobrecarga.Equals(objeto));
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobrecarga.GetHashCode());
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobrecarga.MiMetodo());

            Console.WriteLine("\n2-\n");
            Console.WriteLine(ss.ToString());
            string objeto2 = "¡Este es mi método ToString sobreescrito!";
            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(ss.Equals(objeto2));
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(ss.GetHashCode());
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(ss.MiMetodo());
            Console.ReadKey();
        }
    }
}
