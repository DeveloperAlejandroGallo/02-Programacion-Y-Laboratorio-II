using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej11
{
    class Validacion
    {
        public static bool Validar(int limMax, int limMin, int valor)
        {
            bool ret = true;

            if(valor <= limMax && valor >= limMin)
            {
                ret = true;
            }

            return ret;
        }
    }
}
