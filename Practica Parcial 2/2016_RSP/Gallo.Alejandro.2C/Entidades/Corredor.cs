using System;

namespace Entidades
{
    public abstract class Corredor
    {
        public enum Carril
        {
            Carril_1,
            Carril_2
        }
        
        static protected Random avance;
        short velocidadMax;
        protected Carril carrilElegido; 

        static Corredor()
        {
            avance = new Random();
        }

        protected Corredor(short velocidadMaxima, Carril carril)
        {
            this.velocidadMax = velocidadMaxima;
            this.carrilElegido = carril;
        }


        public Carril CarrilElegido
        {
            get
            {
                return this.carrilElegido;
            }
            
        }

        public short VelocidadMaxima
        {
            get
            {
                return this.velocidadMax;
            }
            set
            {
                this.velocidadMax = value;
            }
        }

        public abstract void Correr();
        
        public virtual void Guardar(string path)
        {
            throw new NotImplementedException();
        }

    }
}
