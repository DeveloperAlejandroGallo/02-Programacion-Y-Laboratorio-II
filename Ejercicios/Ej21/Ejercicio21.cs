using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej21_Moneda;

namespace Ej21
{
    class Ejercicio21
    {
        static void Main(string[] args)
        {
            Dolar dls = new Dolar();
            Euro eur = new Euro();

            Console.WriteLine("El dolar equivale: {0}", dls.getCotizacion());
            Console.WriteLine("El euro equivale: {0}", eur.getCotizacion());
            Console.WriteLine("La + de Dolar + Euro = {0}", dls + eur);
            Console.WriteLine("La - de Dolar + Euro = {0}", dls - eur);
            Console.WriteLine("La comparacion de Dolar == Euro = {0}", dls == eur);
            Console.WriteLine("Incremento el dolar Dolar = {0}", dls++);
            


            Console.ReadKey();
        }
    }
}
