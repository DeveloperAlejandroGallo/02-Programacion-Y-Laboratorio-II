using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej18_Enum;


namespace Ej18_Class
{
    public class Computadora
    {
        bool estaEncendida;

        EMarca marca;

        float peso;

        EProcesador procesador;

        public Computadora(bool encender, EMarca marca, float peso, EProcesador procesador)
        {
            this.estaEncendida = encender;
            this.marca =  marca;
            this.peso = peso;
            this.procesador = procesador;

        }

        //Getters
        public bool getEstaEncendida()
        {
            return this.estaEncendida;
        }
        public EMarca getMarca()
        {
            return this.marca;
        }
        public float getPeso()
        {
            return this.peso;
        }
        public EProcesador getProcesador()
        {
            return this.procesador;
        }

        //Setters
        public void setEstaEncendida(bool encender)
        {
            this.estaEncendida = encender;
        }
        public void setMarca(EMarca marca)
        {
            this.marca = marca;
        }
        public void setPeso(float peso)
        {
            this.peso = peso;
        }
        public void setProcesador(EProcesador procesador)
        {
            this.procesador = procesador;
        }

        public void InformarEstado()
        {
            
            Console.WriteLine("{0,-10}|{1,-10}|{2,-10}|{3,-10}", this.estaEncendida, this.marca, this.peso, this.procesador);

        }

        public void Encender()
        {
            this.estaEncendida = true;
        }
        public void Apagar()
        {
            this.estaEncendida = false;
        }


    }
}
