using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_4
{
    public class Sumador
    {
        private int cantidadSumas;
        public Sumador ()
        {
            this.cantidadSumas = 0;
        }

        public Sumador(int valor)
        {
            this.cantidadSumas = valor;
        }

        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }
        
        public string Sumar(string a, string b)
        {
            long a1, b1;
            string ret;

            if(long.TryParse(a,out a1))
            {
                if(long.TryParse(b,out b1))
                {
                    ret = (a1 + b1).ToString();
                    this.cantidadSumas++;
                }
                else
                    ret = "Error!";
            }
            else
                ret = "Error!";


            return ret;
        }

        public long getCantidadSumas()
        {
            return (long)this.cantidadSumas;
        }

        public static long operator +(Sumador a, Sumador b)
        {
            long c=0;

            c = a.getCantidadSumas() + b.getCantidadSumas();

            return c;
        }

        //Esto sirve para que cuando castee como long a un Sumador, devuelva la cantidad de sumas.
        public static explicit operator long (Sumador a)
        {
            return a.getCantidadSumas();
        }

        public static bool operator |(Sumador a, Sumador b)
        {
            return a.getCantidadSumas() == b.getCantidadSumas();
        }

    }
}
