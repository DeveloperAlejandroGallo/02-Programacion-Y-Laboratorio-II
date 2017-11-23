using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace Entidades
{
    public class Persona : Corredor
    {
        

        public delegate void CorrenCallback(int avance, Corredor corredor);
        public event CorrenCallback Corriendo;

        string nombre;

        public Persona(string nombre, short velocidad, Carril carril)
            :base(velocidad, carril)
        {
            this.nombre = nombre;
        }

        public override void Correr()
        {
            while(true)
            {
                
                this.Corriendo(avance.Next(1, VelocidadMaxima), this);
                Thread.Sleep(300);
            }
        }

        public override void Guardar(string path)
        {
            StreamWriter file=null;
            try
            {
                if (File.Exists(path))
                    file = new StreamWriter(path, true);
                else
                    file = new StreamWriter(path);

                file.WriteLine(this.ToString());
            }
            catch(Exception )
            {
                throw new NoSeGuardoException();
            }
            finally
            {
                if(file != null)
                    file.Close();
            }
        }

        public override string ToString()
        {
            return string.Format("{0} en el carril {1} a una velocidad de {2}",this.nombre,
                base.CarrilElegido, base.VelocidadMaxima);
        }
    }
}
