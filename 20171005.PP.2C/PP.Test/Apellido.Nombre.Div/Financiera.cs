using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;

namespace EntidadFinanciera
{
    public class Financiera
    {
        #region Atributos

        List<Prestamo> listaDePrestamos;
        string razonSocial;

        #endregion

        #region Propiedades

        public List<Prestamo> ListaDePrestamos
        {
            get
            {
                return this.listaDePrestamos;
            }
        }

        public float InteresesEnDolares
        {
            get
            {
                return this.CalcularInteresGanado(TipoDePrestamo.Dolares);
            }
        }

        public float InteresesEnPesos
        {
            get
            {
                return this.CalcularInteresGanado(TipoDePrestamo.Pesos);
            }
        }

        public float InteresesTotales
        {
            get
            {
                return this.CalcularInteresGanado(TipoDePrestamo.Todos);
            }
        }

        public string RazonSocial
        {
            get
            {
                return this.razonSocial;
            }
        }


        #endregion

        #region Constructores

        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial)
            : this()
        {
            this.razonSocial = razonSocial;
        }
        
        #endregion

        #region Metodos

        public static string Mostrar(Financiera financiera)
        {
            return (string)financiera;
        }

        public void OrdenarPrestamos()
        {
            this.ListaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }

        private float CalcularInteresGanado(TipoDePrestamo tipoPrestamo)
        {
            float 
             interesesEnPesos = 0,
             interesesEnDolares = 0,
             interesGanado = 0;

            foreach (Prestamo prestamo in this.ListaDePrestamos)
            {
                if (prestamo is PrestamoDolar)
                    interesesEnDolares += ((PrestamoDolar)prestamo).Interes;
                if (prestamo is PrestamoPesos)
                    interesesEnPesos += ((PrestamoPesos)prestamo).Interes;
            }

            switch (tipoPrestamo)
            {
                case TipoDePrestamo.Dolares:
                    interesGanado = interesesEnDolares;
                    break;
                case TipoDePrestamo.Pesos:
                    interesGanado = interesesEnPesos;
                    break;
                default:
                    interesGanado = interesesEnPesos + interesesEnDolares;
                    break;

            }

            return interesGanado;
        }
        
        #endregion


        #region Conversiones

        public static explicit operator string(Financiera financiera)
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("FINANCIERA: {0}\n", financiera.RazonSocial);
            str.AppendLine("Intereses Ganados\n");
            str.AppendFormat("TOTALES {0}\n", financiera.InteresesTotales);
            str.AppendFormat("PESOS {0}\n", financiera.InteresesEnPesos);
            str.AppendFormat("DOLARES {0}\n", financiera.InteresesEnDolares);
            str.AppendLine();
            foreach (Prestamo p in financiera.ListaDePrestamos)
            {
                str.AppendLine(p.Mostrar());
            }

                        
            return str.ToString();
        }

        #endregion

        #region Sobrecarga de Operadores

        public static bool operator ==(Financiera financiera, Prestamo prestamo)
        {
            foreach (Prestamo pres in financiera.ListaDePrestamos)
            {
                if (pres.Monto == prestamo.Monto && pres.Vencimiento == prestamo.Vencimiento)
                    return true;
            }

            return false;
        }

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        { 
            return !(financiera == prestamo);
        }

        public static Financiera operator +(Financiera financiera, Prestamo prestamo)
        {
            if (financiera != prestamo)
                financiera.listaDePrestamos.Add(prestamo);

            return financiera;
        }
        
        #endregion

    }
}
