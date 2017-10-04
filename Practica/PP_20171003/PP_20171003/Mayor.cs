using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_20171003
{
    public class Mayor : Comensal
    {
        #region Enumerables
        
        public enum EBebida
        {
            Agua, 
            Cerveza, 
            Vino, 
            Gaseosa
        }

        #endregion

        #region Atributos

        EBebida bebida;

        #endregion

        #region Propiedades

        public EBebida Bebida
        {
            get 
            { 
                return this.bebida; 
            }

        }
        
        
        #endregion

        #region Constructores

        public Mayor(string nombre, string apellido, EBebida bebida)
            : this(nombre,apellido)
        {
            this.bebida = bebida;
        }

        private Mayor(string nombre, string apellido)
            :base(nombre, apellido)
        { }

        #endregion

        #region Metodos



        #endregion
        
        #region Sobrecarga Operadores
        /// <summary>
        /// Dos Mayores serán iguales si comparten nombre, apellido y bebida.
        /// </summary>
        /// <returns></returns>
        public static bool operator ==(Mayor unMayor, Mayor otroMayor)
        {
            return (unMayor.Nombre == otroMayor.Nombre
                && unMayor.Apellido == otroMayor.Apellido);
        }

        public static bool operator !=(Mayor unMayor, Mayor otroMayor)
        {
            return !(unMayor == otroMayor);
        }

        public static explicit operator string(Mayor m)
        {
            return string.Format("{0} {1}", m.Mostrar(), m.bebida);
        }

        #endregion

        #region Sobreescritos

        public override string ToString()
        {
            return (string)this;
        }

        public override bool Equals(object obj)
        {
            return obj == this;
        }

        #endregion

    }
}
