using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej40_Entidades
{
    public class CentralitaException : Exception
    {
        string nombreClase;
        string nombreMetodo;

        public string NombreClase
        {
            get
            {
                return nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return nombreMetodo;
            }
        }


        public Exception ExcepcionInterna
        {
            get 
            {
                return base.InnerException;
            }
        }

        public CentralitaException(string mensaje, string clase, string metodo)
            :this(mensaje,clase, metodo, null)
        {
            this.nombreMetodo = metodo;
            this.nombreClase = clase;
           
        }

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        { }



    }
}
