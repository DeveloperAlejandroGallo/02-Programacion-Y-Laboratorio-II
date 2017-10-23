using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej47
{
    public class Recibo : Documento
    {
        public Recibo() 
            : this(1)
        {          
        }

        public Recibo(int nro)
            : base(nro)
        { }
    }
}