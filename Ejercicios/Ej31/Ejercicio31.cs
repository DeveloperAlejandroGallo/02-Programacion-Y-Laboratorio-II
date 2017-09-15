using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej31
{
    class Ejercicio31
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio 31";

            Cliente cli1 = new Cliente(1, "Ale");
            Cliente cli2 = new Cliente(2, "cli2");
            Cliente cli3 = new Cliente(3, "cli3");

            PuestoAtencion puesto1 = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);

            Negocio neg = new Negocio("Pollo Hnos");

            if (neg + cli1)
            {
                Console.WriteLine("cliente 1 atroden");
            }
            if (neg + cli2)
            {
                Console.WriteLine("cliente 1 atroden");
            }

            puesto1.Atender(neg.Cliente);
            

        }
    }
}
