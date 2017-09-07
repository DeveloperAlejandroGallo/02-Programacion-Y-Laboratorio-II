using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej21_Moneda
{
    public class Dolar
    {
        static double cotizacion;

        public double cantidad;

        static Dolar()
        {
            cotizacion = 1.0;
        }

        public Dolar(double cant)
        {
            this.cantidad = cant;
        }
        public Dolar(double cant, double cotiz)
        {
            this.cantidad = cant;
            Dolar.cotizacion = cotiz;
        }

        public double Cotizar(Euro moneda)
        {
            return moneda.cantidad * Dolar.cotizacion;
        }
        public double Cotizar(Peso moneda)
        {
            return moneda.cantidad * Dolar.cotizacion;
        }

        //Dolares
        public static double operator +(Dolar d, Peso p)
        {
            return (p.cantidad * Dolar.cotizacion) + d.cantidad;
        }
        public static double operator -(Dolar d, Peso p)
        {
            return (p.cantidad * Dolar.cotizacion) - d.cantidad;
        }
        public static bool operator ==(Dolar d, Peso p)
        {
            return (p.cantidad * Dolar.cotizacion) == d.cantidad;
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(p == d);
        }

        //Euro
        public static double operator +(Dolar d, Euro e)
        {
            return (e.cantidad * Dolar.cotizacion) + d.cantidad;
        }
        public static double operator -(Dolar d, Euro e)
        {
            return (e.cantidad * Dolar.cotizacion) - d.cantidad;
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            return (e.cantidad * Dolar.cotizacion) == d.cantidad;
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }


        public static Dolar operator ++(Dolar d)
        {
            d.cantidad++;

            return d;
        }
        public static Dolar operator --(Dolar d)
        {

            d.cantidad--;
            return d;
        }
        
        public static explicit operator double(Dolar d)
        {
            return d.cantidad;
        }

        public static double getCotizacion()
        {
            return Dolar.cotizacion;
        }
    }
}
