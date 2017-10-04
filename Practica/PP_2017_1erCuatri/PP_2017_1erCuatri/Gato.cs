using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_2017_1erCuatri
{
    public class Gato : Mascota
    {
        #region Constructores
        
        public Gato(string nombre, string raza)
            : base(nombre, raza)
        { }

        #endregion

        #region Metodos

        protected override string Ficha()
        {

            return base.DatosCompletos();
        }

        #endregion

        #region Sobrecarga operadores

        public static bool operator ==(Gato unGato, Gato otroGato)
        {
            return (unGato.Nombre == otroGato.Nombre
                 && unGato.Raza == otroGato.Raza);
        }

        public static bool operator !=(Gato unGato, Gato otroGato)
        {
            return !(unGato == otroGato);
        }

        public override bool Equals(object obj)
        {
            return obj == this;
        }

        public override string ToString()
        {
            return this.Ficha();
        }
        #endregion
    }
}
