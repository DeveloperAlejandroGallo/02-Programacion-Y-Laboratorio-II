using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej21_Moneda
{
    class Dolar
    {
        double cotizacion;

        public Dolar()
        {
            this.cotizacion = 1.0;
        }

        public double Value
        {
            get
            {
                return cotizacion;
            }
        }

        public static double operator +(Dolar d, Euro e)
        {
            return d.getCotizacion() + e.getCotizacion();
        }
        public static double operator -(Dolar d, Euro e)
        {
            return d.getCotizacion() - e.getCotizacion();
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            return d.getCotizacion() == e.getCotizacion();
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return d.getCotizacion() != e.getCotizacion();
        }

        public static Dolar operator ++(Dolar d)
        {
            d++;
            
            return d;
        }
        public static Dolar operator --(Dolar d)
        {

            d--;
            return d;
        }


        public double getCotizacion()
        {
            return this.cotizacion;
        }

        public void setCotizacion(double coti)
        {
            this.cotizacion = coti;
        }


        public static explicit operator double (Dolar d)
        {
            return d.getCotizacion();
        }

    }
}
