using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public class Menor : Comensal
    {
        #region Enumerables

        public enum eMenu
        {
            Milanesa,
            Hambuergesa
        }

        #endregion

        #region Atributos

        eMenu menu;

        #endregion

        #region Propiedades

        public eMenu Menu
        {
            get
            {
                return this.menu;
            }
            set
            {
                this.menu = value;
            }
        }


        #endregion

        #region Constructores

        public Menor(string nombre, string apellido, eMenu menu)
            : this(nombre, apellido)
        {
            this.menu = menu;
        }

        private Menor(string nombre, string apellido)
            : base(nombre, apellido)
        { }

        #endregion

        #region Metodos

        public override string Mostrar()
        {
            return string.Format("{0} {1} Menor", base.Mostrar(), this.Menu);
        }

        #endregion

        #region Sobrecarga Operadores
        /// <summary>
        /// Dos Menores serán iguales si comparten nombre, apellido y menu.
        /// </summary>
        /// <returns></returns>
        public static bool operator ==(Menor unMenor, Menor otroMenor)
        {
            return (unMenor.Nombre == otroMenor.Nombre
                && unMenor.Apellido == otroMenor.Apellido
                && unMenor.Menu == otroMenor.Menu);
        }

        public static bool operator !=(Menor unMenor, Menor otroMenor)
        {
            return !(unMenor == otroMenor);
        }

        #endregion

        #region Sobreescritos

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return obj == this;
        }

        #endregion

    }
}
