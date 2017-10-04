using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_2017_1erCuatri
{
    /// <summary>
    /// No será instanciable
    /// </summary>
    public abstract class Mascota
    {
        #region Atributos
        string nombre;
        string raza;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Raza
        {
            get
            {
                return this.raza;
            }
        }
        #endregion

        #region Constructores
        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }
        #endregion

        #region Metodos

        protected abstract string Ficha();

        protected virtual string DatosCompletos()
        {
            return this.Nombre + " " + this.Raza;
        }
        #endregion

    }
}
