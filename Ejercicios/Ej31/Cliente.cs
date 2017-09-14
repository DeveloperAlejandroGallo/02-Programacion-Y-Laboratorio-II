using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej31
{
    public class Cliente
    {
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public Cliente(int numero);

        public Cliente(int numero, string nombre);

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if (c1.Numero == c2.Numero)
                return true;
            else
                return false;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }


    }
}
