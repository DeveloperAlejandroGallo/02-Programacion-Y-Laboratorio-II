using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20161201_RPP
{
    public class Humano : Animal
    {
        #region Atributos

        string apellido;
        string nombre;
        static int piernas;
        
        #endregion

        #region Contructores
        static Humano()
        {
            Humano.piernas = 2;
        }

        public Humano(int velocidadMax)
            : base(Humano.piernas, velocidadMax)
        { }

        public Humano(string nombre, string apellido, int velocidadMax)
            : this(velocidadMax)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        
        #endregion

        #region Metodos
        public string MostrarHumano()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("HUMANO");
            str.AppendLine(base.MostrarDatos());
            str.AppendFormat("Apellido: {0}\r\n", this.apellido);
            str.AppendFormat("Nombre: {0}\r\n", this.nombre);



            return str.ToString();
        } 
        #endregion


        #region Sobrecarga Operadores

        public static bool operator ==(Humano unHumano, Humano otroHumano)
        {
            return (unHumano.apellido == otroHumano.apellido && unHumano.nombre == otroHumano.nombre);
        }

        public static bool operator !=(Humano unHumano, Humano otroHumano)
        {
            return !(unHumano == otroHumano);
        }

        #endregion

    }
}
