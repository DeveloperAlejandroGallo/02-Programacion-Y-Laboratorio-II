using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Ejercicio20
    {
        static void Main(string[] args)
        {
            Punto v1 = new Punto(0,0),
                  v3 = new Punto(4,4);

            Rectangulo rec = new Rectangulo(v1, v3);

            Console.WriteLine("Rectangulo: \nBase: {0}\nLado: {1}\nArea: {2}\nPerimetro:{3}", rec.largoBase,rec.lado, rec.area, rec.perimetro);

            Console.ReadKey();
        }
    }
}
