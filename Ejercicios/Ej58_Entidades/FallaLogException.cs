using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej58_Entidades
{
    public class FallaLogException : Exception
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

        public FallaLogException(string mensaje, string clase, string metodo)
            :this(mensaje,clase, metodo, null)
        {
            this.nombreMetodo = metodo;
            this.nombreClase = clase;
           
        }

        public FallaLogException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        { }



    }
}
