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
            : base(piernas, velocidadMax)
        { }

        public Humano(string nombre, string apellido, int velocidadMax)
            : this(velocidadMax)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        
        #endregion

        public string MostrarHumano()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("Apellido: {0}\n", this.apellido);
            str.AppendFormat("Nombre: {0}\n", this.nombre);
            str.AppendFormat("Piernas: {0}\n", Humano.piernas);

            return str.ToString();
        }


    }
}
