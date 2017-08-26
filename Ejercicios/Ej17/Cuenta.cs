using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej17
{
    class Cuenta
    {
        public enum ETipoInteres
        {
            TIN,
            TAE,
            TIR
        };

        //
        private string nombre;

        private long nroCuenta;

        private double saldo;

        private ETipoInteres tipoInteres;

        //getters
        public string getNombre()
        {
            return nombre;
        }

        public long getNroCuenta()
        {
            return nroCuenta;
        }

        public double getSaldo()
        {
            return saldo;
        }

        public ETipoInteres getTipoInteres()
        {
            return tipoInteres;
        }

        //setters
        public void setNombre(string nom)
        {
            nombre = nom;
        }

        public void setNroCuenta(long nro)
        {
            if(nro > 0)
               nroCuenta = nro;
        }

        public void setSaldo(long nro)
        {
            saldo = nro;
        }

        public void setTipoInteres(ETipoInteres tInt)
        {
            if (tInt == ETipoInteres.TAE || tInt == ETipoInteres.TIN || tInt == ETipoInteres.TIR)
                tipoInteres = tInt;
        }




    }
}
