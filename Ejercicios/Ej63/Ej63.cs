using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ej63
{
    class Ej63
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();

            Negocio negocio = new Negocio(caja1,caja2);

            for (int i = 0; i < 10; i++)
                negocio.Clientes.Add("Cliente " + i);

            Thread asignador = new Thread(negocio.AsignarCaja);
            Thread atenderCaja1 = new Thread(caja1.AtenderClientes);
            atenderCaja1.Name = "Caja 1";
            Thread atenderCaja2 = new Thread(caja2.AtenderClientes);
            atenderCaja2.Name = "Caja 2";

            asignador.Start();
            asignador.Join();
            atenderCaja1.Start();
            atenderCaja2.Start();

            Console.ReadKey();



        }
    }
}
