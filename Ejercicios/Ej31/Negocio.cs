using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej31
{
    public class Negocio
    {
        PuestoAtencion caja;

        Queue<Cliente> clientes;

        string nombre;


        private Negocio()
        {
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            this.clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre)
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool esta = false;

            foreach (Cliente cli in n.clientes)
            {
                if (cli == c)
                {
                    esta = true;
                    break;
                }
            }

            return esta;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n==c);
        }


        /// <summary>
        /// get: Propiedad que retorna el prox cliente en la cola de atencion.
        /// set: 
        /// </summary>
        public Cliente Cliente
        {
            
            get 
            { 
                return clientes.Dequeue(); 
            }
            set 
            {
                //This es el Negocio, value es el Cliente. Se reutiliza el !=
                if (this != value)
                    clientes.Enqueue(value);
            }
        }



        public static bool operator +(Negocio n, Cliente c)
        {
            bool agregado=false;

            if(n==c)
            {
                n.clientes.Enqueue(c);
                agregado = true;
            }

            return agregado;
        }

        
        public static bool operator ~(Negocio n)
        {

            n.caja.Atender(n.Cliente);
            return true;

        }

    }
}
