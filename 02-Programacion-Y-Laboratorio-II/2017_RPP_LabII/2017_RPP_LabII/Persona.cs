using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_RPP_LabII
{
    public abstract class Persona
    {

        private string nombre;

        private string apellido;

        #region Constructores

        public Persona(string nombre,string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;

        }

        #endregion
        
        #region Propiedades

        public string Nombre
        {
            get { return this.nombre; }
        }
        public string Apellido
        {
            get { return this.apellido; }
        }

        #endregion

        #region Metodos

        protected abstract string FichaTecnica();

        protected virtual string NombreCompleto()
        {
            return string.Format("{0} {1}", this.Nombre, this.Apellido);
        }
        



        #endregion

    }
}
