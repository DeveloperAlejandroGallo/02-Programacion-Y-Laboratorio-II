using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20161201_RPP
{
    public class Caballo : Animal
    {
        #region Atributos
        
        string nombre;
        static int patas; 
        
        #endregion

        #region Constructores
        
        static Caballo()
        {
            Caballo.patas = 4;
        }

        public Caballo(string nombre, int velocidadMaxima) 
            : base(Caballo.patas, velocidadMaxima)
        {
            this.nombre = nombre;
        }

        #endregion

        #region Metodos
        
        public string MostrarCaballo()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("CABALLO");
            str.AppendLine(base.MostrarDatos());
            str.AppendFormat("Nombre: {0}\r\n", this.nombre);

            return str.ToString();
        }

        #endregion

        #region Sobrecarga Operadores
        public static bool operator ==(Caballo unCaballo, Caballo otroCaballo)
        {
            return (unCaballo.nombre == otroCaballo.nombre);
        }

        public static bool operator !=(Caballo unCaballo, Caballo otroCaballo)
        {
            return !(unCaballo == otroCaballo);
        }
        #endregion
    }
}
