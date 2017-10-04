using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_2017_1erCuatri
{
    public class Perro : Mascota
    {
        #region Atributos
        int edad;
        bool esAlfa;
        
        #endregion

        #region Constructores
        
        public Perro(string nombre, string raza, int edad, bool esAlfa)
            : base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        public Perro(string nombre, string raza)
            : this(nombre, raza, 0, false)
        {

        }

        #endregion

        #region Metodos

        protected override string Ficha()
        {
            StringBuilder str = new StringBuilder();

            str.Append(base.DatosCompletos());
            if (this.esAlfa)
                str.Append(", alfa de la manada,");
            str.AppendFormat(" edad {0}", this.edad);

            return str.ToString();
        }

        #endregion

        #region Sobrecarga operadores
        
        public static bool operator ==(Perro unPerro, Perro otroPerro)
        {
            return (unPerro.Nombre == otroPerro.Nombre
                 && unPerro.Raza == otroPerro.Raza
                 && unPerro.edad == otroPerro.edad);
        }

        public static bool operator !=(Perro unPerro, Perro otroPerro)
        {
            return !(unPerro == otroPerro);
        }

        public static explicit operator int(Perro unPerro)
        {
            return unPerro.edad;
        }

        public override bool Equals(object obj)
        {
            var objeto = obj as Perro;

            return objeto != null;
        }

        public override string ToString()
        {
            return this.Ficha();
        }
        #endregion

    }
}
