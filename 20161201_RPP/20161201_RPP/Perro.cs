using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20161201_RPP
{
    public class Perro : Animal
    {
        #region Enumerables
        
        public enum Razas
        {
            Galgo,
            OvejeroAleman
        }

        #endregion

        #region Atributios

        static int patas;
        Razas raza;

        #endregion

        #region Constructores
        
        static Perro()
        {
            Perro.patas = 4;
        }

        public Perro(int velocidadMax)
            : base(Perro.patas, velocidadMax)
        { }

        public Perro(Razas raza, int velocidadMax)
            : this(velocidadMax)
        {
            this.raza = raza;
        }

        #endregion

        #region Metodos
        
        public string MostrarPerro()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("PERRO");
            str.AppendLine(base.MostrarDatos());
            str.AppendFormat("Raza: {0}\r\n", this.raza);

            return str.ToString();
        }

        #endregion

        #region Sobrecarga Operadores
        public static bool operator ==(Perro unPerro, Perro otroPerro)
        {
            return (unPerro.raza == otroPerro.raza && unPerro.VelocidadMaxima == otroPerro.VelocidadMaxima);
        }

        public static bool operator !=(Perro unPerro, Perro otroPerro)
        {
            return !(unPerro == otroPerro);
        }

        #endregion
    }
}
