using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public class Mesa
    {

        #region Atributos

        List<Comensal> comensales;
        int numero;
        static int capacidad;

        #endregion

        #region Constructores

        static Mesa()
        {
            capacidad = 12;
        }

        private Mesa()
        {
            this.comensales = new List<Comensal>();
        }

        public Mesa(int numero)
            : this()
        {
            this.Numero = numero;
        }
        #endregion

        #region Propiedades

        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        public List<Comensal> Comensales
        {
            get
            {
                return this.comensales;
            }
        }

        public int Cantidad
        {
            get
            {
                return Mesa.capacidad;
            }
        }


        #endregion

        #region Sobrecarga Operadores

        public static bool operator ==(Mesa mesa1, Mesa mesa2)
        {
            return mesa1.numero == mesa2.numero;
        }

        public static bool operator !=(Mesa mesa1, Mesa mesa2)
        {
            return !(mesa1 == mesa2);
        }

        public static Mesa operator +(Mesa mesa, Comensal comensal)
        {

            if (mesa.comensales.Count < Mesa.capacidad)
            {
                foreach (Comensal c in mesa.comensales)
                {
                    if (c == comensal)
                        return mesa;
                }
                mesa.comensales.Add(comensal);
            }
            return mesa;
        }

        public static implicit operator string(Mesa m)
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("MESA: {0} Comensales: {1}\n", m.numero, m.comensales.Count);
            foreach (Comensal c in m.comensales)
            {
                //if (c is Menor)
                //    str.AppendLine(((Menor)c).ToString());
                //if (c is Mayor)
                //    str.AppendLine(((Mayor)c).ToString());

                str.AppendLine(c.ToString());
            }

            return str.ToString();
        }

        #endregion
    }
}
