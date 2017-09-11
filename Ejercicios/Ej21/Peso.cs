using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej21_Moneda
{
    public class Peso
    {
        static double cotizacion;

        public double cantidad;

        static Peso()
        {
            cotizacion = 17.55;
        }

        public Peso(double cant)
        {
            this.cantidad = cant;
        }
        public Peso(double cant, double cotiz)
        {
            this.cantidad = cant;
            Peso.cotizacion = cotiz;
        }

        public double Cotizar(Dolar moneda)
        {
            return moneda.cantidad * Peso.cotizacion;
        }
        public double Cotizar(Euro moneda)
        {
            return moneda.cantidad * Peso.cotizacion;
        }

        //Dolares
        public static double operator +(Peso p, Dolar d)
        {
            return (d.cantidad * Peso.cotizacion) + p.cantidad;
        }
        public static double operator -(Peso p, Dolar d)
        {
            return (d.cantidad * Peso.cotizacion) - p.cantidad;
        }
        public static bool operator ==(Peso p, Dolar d)
        {
            return (d.cantidad * Peso.cotizacion) == p.cantidad;
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(d == p);
        }

        //Euro
        public static double operator +(Peso p, Euro e)
        {
            return (e.cantidad * Peso.cotizacion) + p.cantidad;
        }
        public static double operator -(Peso p, Euro e)
        {
            return (e.cantidad * Peso.cotizacion) - p.cantidad;
        }
        public static bool operator ==(Peso p, Euro e)
        {
            return (e.cantidad * Peso.cotizacion) == p.cantidad;
        }
        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }


        public static Peso operator ++(Peso p)
        {
            p.cantidad++;

            return p;
        }
        public static Peso operator --(Peso p)
        {

            p.cantidad--;
            return p;
        }



        public static explicit operator double(Peso p)
        {
            return p.cantidad;
        }

        public static double getCotizacion()
        {
            return Peso.cotizacion;
        }
    }
}
