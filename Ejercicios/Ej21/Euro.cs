using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej21_Moneda
{
    class Euro
    {
        double cotizacion;

        public Euro()
        {
            this.cotizacion = 1.3642;
        }

        public static double operator +(Euro e, Dolar d )
        {
            return d.getCotizacion() + e.getCotizacion();
        }
        public static double operator -(Euro e, Dolar d)
        {
            return d.getCotizacion() - e.getCotizacion();
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return d.getCotizacion() == e.getCotizacion();
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return d.getCotizacion() != e.getCotizacion();
        }
        public static Euro operator ++(Euro e)
        {
            e++;

            return e;
        }
        public static Euro operator --(Euro e)
        {

            e--;
            return e;
        }


        public double getCotizacion()
        {
            return this.cotizacion;
        }

        public void setCotizacion(double coti)
        {
            this.cotizacion = coti;
        }

        public static explicit operator double(Euro  d)
        {
            return d.getCotizacion();
        }

    }
}
