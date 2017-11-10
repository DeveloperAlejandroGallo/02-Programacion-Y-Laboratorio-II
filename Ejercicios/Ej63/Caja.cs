using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ej63
{
    public class Caja
    {
        List<string> filaDeClientes;

        public List<string> FilaDeClientes
        {
            get
            {
                return this.filaDeClientes;
            }
        }

        public Caja()
        {
            filaDeClientes = new List<string>();
        }

        public void AtenderClientes()
        {
            foreach(string cli in filaDeClientes)
            {
                Console.WriteLine("Cliente {0} atendido en {1}", cli, Thread.CurrentThread.Name);
                Thread.Sleep(2000);
            }
        }
    }
}
