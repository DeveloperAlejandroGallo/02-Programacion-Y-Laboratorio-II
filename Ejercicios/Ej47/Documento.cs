using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej47
{
    public class Documento
    {
        int numero;

        public Documento(int numero)
        {
            this.numero = numero;
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }


    }
}
