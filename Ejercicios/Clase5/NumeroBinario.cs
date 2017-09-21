using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej13;

namespace Clase5
{
    class NumeroBinario
    {
        string numero;

        public NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public static string operator +(NumeroBinario b, NumeroDecimal d)
        {

            return Conversor.DecimalABinario(Conversor.BinarioADecimal(b.getNro()) + d.getNro());
        }
        public static string operator -(NumeroBinario b, NumeroDecimal d)
        {

            return Conversor.DecimalABinario(Conversor.BinarioADecimal(b.getNro()) - d.getNro());
        }
        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {

            return Conversor.BinarioADecimal(b.getNro()) == d.getNro();
        }

        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {

            return Conversor.BinarioADecimal(b.getNro()) != d.getNro();
        }

        public static implicit operator NumeroBinario(string str)
        {
            return new NumeroBinario(str);
        }

        public static explicit operator string(NumeroBinario b)
        {
            return b.getNro();
        }
        public string getNro()
        {
            return this.numero;
        }
    }
}
