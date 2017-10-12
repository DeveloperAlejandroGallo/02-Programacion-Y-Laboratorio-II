using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public abstract class Comensal
    {
        #region Atributos
        string apellido;
        string nombre;
        #endregion

        #region Constructores

        public Comensal(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }


        #endregion

        #region Propiedades

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        #endregion

        #region Metodos

        public virtual string Mostrar()
        {
            return String.Format("{0} {1}", this.Apellido, this.Nombre);
        }


        #endregion
    }
}
