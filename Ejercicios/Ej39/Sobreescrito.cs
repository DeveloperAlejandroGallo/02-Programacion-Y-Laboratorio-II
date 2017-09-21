using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej39
{
    public abstract class Sobreescrito
    {

        protected string miAtributo;

        #region Constructores
        public Sobreescrito()
        {
            this.miAtributo = "Probar Abstractos";
        } 
        #endregion

        #region Propiedades
        public abstract string MiAtributo
        { 
            get; 
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }

        public override bool Equals(object obj)
        {
            return (obj is Sobreescrito);
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }

        public abstract string MiMetodo();

        #endregion
    }
}
