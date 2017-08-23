using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej14
{
    public class CalculoDeArea
    {

        static double CalcularCuadrado(int lado)
        {
            return Math.Pow(lado,2);
        }

        static double CalcularTriangulo(int baseTriangulo, int altura)
        {
            return (baseTriangulo * altura ) /2;
        }

        static double CalcularCirculo(int radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
