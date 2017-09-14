using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ej31
{
    public class PuestoAtencion
    {

        public enum Puesto
        {
            Caja1=1,
            Caja2
        }

        static int numeroActual;
        
        public static int NumeroActual
        {
            get 
            { 
                return ++numeroActual; 
            }
        }

        Puesto puesto;

        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }


        public bool Atender(Cliente cli)
        {
            Thread.Sleep(3000);
            return true;
        }



    }

        
        
    }
}
