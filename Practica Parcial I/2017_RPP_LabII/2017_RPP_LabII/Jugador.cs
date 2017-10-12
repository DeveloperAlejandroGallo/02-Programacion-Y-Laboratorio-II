using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_RPP_LabII
{
    public class Jugador : Persona
    {

        #region Atributos
        int numero;

        bool esCapitan;
        
        #endregion

        #region Propiedades
        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        public bool EsCapitan
        {
            get
            {
                return this.esCapitan;
            }
        } 
        #endregion

        #region Constructores
        public Jugador(string nombre, string apellido)
            : this(nombre, apellido,0,false)
        {
            
        }

        public Jugador(string nombre, string apellido, int numero, bool esCapitan)
            : base(nombre, apellido)
        {
            this.numero = numero;
            this.esCapitan = esCapitan;
        } 
        #endregion


        #region Metodos
        protected override string FichaTecnica()
        {
            StringBuilder str = new StringBuilder();
            str.Append(NombreCompleto());

            if (this.EsCapitan)
                str.Append(",capitán del equipo,");

            str.AppendFormat(" camiseta número {0}", this.numero);

            return str.ToString();
        }


        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Nombre == j2.Nombre & j1.Apellido == j2.Apellido & j1.Numero == j2.Numero;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public static explicit operator int(Jugador jugador)
        {
            return jugador.Numero;
        }

        public override string ToString()
        {
            return this.FichaTecnica();
        }
        /// <summary>
        /// Como es de instancia utiliza el this
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool ret=false;
            if (obj is Jugador)
                ret = (this == (Jugador)obj);
            
            return ret;
        }





        #endregion




    }
}
