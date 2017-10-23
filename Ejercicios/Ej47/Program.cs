using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej47
{
    class Program
    {
        static void Main(string[] args)
        {

            Recibo r1 = new Recibo(1);
            Factura f1 = new Factura(2);
            Recibo r2 = new Recibo(3);
            Factura f2 = new Factura(4);
            Recibo r3 = new Recibo(5);
            Factura f3 = new Factura(6);

            Contabilidad<Factura, Recibo> cont = new Contabilidad<Factura, Recibo>();

            cont = cont + r1;
            cont = cont + f1;
            cont = cont + r2;
            cont = cont + f2;
            cont = cont + r3;
            cont = cont + f3;

            foreach(Documento e in cont.egresos)
            {
                Console.WriteLine("Egreso Nro: {0}", e.Numero);
            }
            Console.WriteLine();
            foreach (Documento e in cont.ingresos)
            {
                Console.WriteLine("Ingreso Nro: {0}", e.Numero);
            }

            Console.ReadKey();

        }
    }
}
