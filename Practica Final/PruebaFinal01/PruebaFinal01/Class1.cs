using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaFinal01
{
    public class Class1
    {
        int nro = 1;
        public void Hola()
        { }

        protected int Nro
        {
            get
            {
                return nro;
            }
        }

        public Class1(int a)
        {
            nro = a;
        }
        
    }
}
