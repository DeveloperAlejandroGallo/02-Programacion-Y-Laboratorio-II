﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20161201_RPP
{
    public abstract class Animal
    {
        #region Atributos
        protected int cantidadPatas;
        protected static Random distanciaRecorrida;
        protected int velocidadMaxima;

        #endregion



        #region Propiedades
        public int CantidadPatas
        {
            get
            {
                return cantidadPatas;
            }
            set
            {
                if (value > 4)
                    cantidadPatas = 4;
                else
                    cantidadPatas = value;
            }
        }

        private int DistanciaRecorrida
        {
            get
            {
                return distanciaRecorrida.Next(10, this.VelocidadMaxima);
            }

        }


        public int VelocidadMaxima
        {
            get
            {
                return velocidadMaxima;
            }
            set
            {
                if (value > 60)
                    velocidadMaxima = 60;
                else
                    velocidadMaxima = value;
            }
        } 
        #endregion

        #region Constructores
        static Animal()
        {
            distanciaRecorrida = new Random();
        }

        public Animal(int cantidadPatas, int velocidadMax)
        {
            this.CantidadPatas = cantidadPatas;
            this.VelocidadMaxima = velocidadMax;
        }
        
        #endregion

        #region Metodos
        public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("Cantidad Patas: {0}\r\n", this.CantidadPatas);
            str.AppendFormat("Distancia Recorrida: {0}\r\n", this.DistanciaRecorrida);
            str.AppendFormat("Velocidad Maxima: {0}", this.VelocidadMaxima);

            return str.ToString();
        } 
        #endregion

    }
}
