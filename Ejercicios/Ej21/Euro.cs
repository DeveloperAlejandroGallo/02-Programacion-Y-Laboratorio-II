using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej21_Moneda
{
    public class Euro
    {
        static double cotizacion;

        public double cantidad;

        static Euro()
        {
            cotizacion = 1.3678;
        }

        public Euro(double cant)
        {
            this.cantidad = cant;
        }
        public Euro(double cant, double cotiz)
        {
            this.cantidad = cant;
            Euro.cotizacion = cotiz;
        }

        public double Cotizar(Dolar moneda)
        {
            return moneda.cantidad * Euro.cotizacion;
        }
        public double Cotizar(Peso moneda)
        {
            return moneda.cantidad * Euro.cotizacion;
        }


        //Dolares
        public static double operator +(Euro e, Dolar d)
        {
            return (d.cantidad * Euro.cotizacion) + e.cantidad;
        }
        public static double operator -(Euro e, Dolar d)
        {
            return (d.cantidad * Euro.cotizacion) - e.cantidad;
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return (d.cantidad * Euro.cotizacion) == e.cantidad;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(d == e);
        }

        //Pesos
        public static double operator +(Euro e, Peso p)
        {
            return (p.cantidad * Euro.cotizacion) + e.cantidad;
        }
        public static double operator -(Euro e, Peso p)
        {
            return (p.cantidad * Euro.cotizacion) - e.cantidad;
        }
        public static bool operator ==(Euro e, Peso p)
        {
            return (p.cantidad * Euro.cotizacion) == e.cantidad;
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !(p == e);
        }


        public static Euro operator ++(Euro e)
        {
            e.cantidad++;

            return e;
        }
        public static Euro operator --(Euro e)
        {

            e.cantidad--;
            return e;
        }
        

        public static explicit operator double(Euro d)
        {
            return d.cantidad;
        }

        public static double getCotizacion()
        {
            return Euro.cotizacion;
        }

    }
}
