using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20161201_RPP
{
    public class Carrera
    {
        #region Atributos

        List<Animal> animales;
        int corredoresMax; 

        #endregion

        #region Constructores
        
        private Carrera()
        {
            this.animales = new List<Animal>();
        }

        public Carrera(int corredoresMax)
            : this()
        {
            this.corredoresMax = corredoresMax;
        }

        #endregion

        #region Metodos

        public static string MostrarCarrera(Carrera c)
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("CARRERA");

            for(int i = 0; i < c.animales.Count; i++)
            {
                if (c.animales[i] is Humano)
                    str.AppendLine(((Humano)c.animales[i]).MostrarHumano());
                if (c.animales[i] is Perro)
                    str.AppendLine(((Perro)c.animales[i]).MostrarPerro());
                if (c.animales[i] is Caballo)
                    str.AppendLine(((Caballo)c.animales[i]).MostrarCaballo());
            }


            return str.ToString();
        }

        #endregion

        #region Sobrecarga Operadores

        public static bool operator ==(Carrera c, Animal a)
        {
            foreach(Animal unAnimal in c.animales)
            {
                if(unAnimal == a)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Carrera c, Animal a)
        { 
            return !(c == a);
        }

        public static Carrera operator +(Carrera c, Animal a)
        {
            if(c.animales.Count < c.corredoresMax && c != a)
            {
                c.animales.Add(a);
            }

            return c;
        }

        #endregion


    }
}
