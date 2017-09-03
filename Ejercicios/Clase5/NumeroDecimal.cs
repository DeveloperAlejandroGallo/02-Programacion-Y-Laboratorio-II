using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej13;

namespace Clase5
{
    class NumeroDecimal
    {
        double numero;

        public NumeroDecimal(double numero)
        {
            this.numero = numero;
        }


        public static double operator + (NumeroDecimal d, NumeroBinario b)
        {

            return Conversor.BinarioADecimal(b.getNro()) + d.getNro();
        }
        public static double operator - (NumeroDecimal d, NumeroBinario b)
        {

            return Conversor.BinarioADecimal(b.getNro()) - d.getNro();
        }
        public static bool   operator == (NumeroDecimal d, NumeroBinario b)
        {

            return Conversor.BinarioADecimal(b.getNro()) == d.getNro();
        }

        public static bool   operator != (NumeroDecimal d, NumeroBinario b)
        {

            return Conversor.BinarioADecimal(b.getNro()) != d.getNro();
        }

        public static implicit operator NumeroDecimal(double nro)
        {
            return new NumeroDecimal(nro);
        }

        public static explicit operator double(NumeroDecimal d)
        {
            return d.getNro();
        }

        public double getNro()
        {
            return this.numero;
        }

    }
}
