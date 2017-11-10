using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ej63
{
    public class Negocio
    {
        List<string> clientes;
        Caja caja1;
        Caja caja2;

        #region Propiedades
        public List<string> Clientes
        {
            get
            {
                return this.clientes;
            }
        }

        public Caja Caja1
        {
            get
            {
                return caja1;
            }
        }

        public Caja Caja2
        {
            get
            {
                return caja2;
            }
        } 
        #endregion

        public Negocio(Caja caja1, Caja caja2)
        {
            this.clientes = new List<string>();
            this.caja1 = caja1;
            this.caja2 = caja2;
        }

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando Cajas...");

            foreach(string cli in Clientes)
            {
                if(Caja1.FilaDeClientes.Count() < Caja2.FilaDeClientes.Count())
                { 
                    Caja1.FilaDeClientes.Add(cli);
                    Console.WriteLine(cli + " asignado a Caja 1");
                }
                else
                { 
                    Caja2.FilaDeClientes.Add(cli);
                    Console.WriteLine(cli + " asignado a Caja 2");
                }

                Thread.Sleep(1000);
            }

        }
    }
}
