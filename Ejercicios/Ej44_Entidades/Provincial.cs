using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej44_Entidades
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1 = 99,
            Franja_2 = 125,
            Franja_3 = 66
        }

        protected Franja franjaHoraria;

        #region Propiedades

        public override float CostoLlamada
        {
            get 
            {
                int franja = (int)this.franjaHoraria;
                return ((float)franja / 100);
            }
        }

        #endregion

        #region Constructores

        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroDestino)
        {
            
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        #endregion

        #region Metodos

        private float CalcularCosto()
        {
            return this.CostoLlamada * base.Duracion;
        }

        protected override string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0}|{1,-10}|{2,-10}|{3,-10}\n", base.Mostrar(), "PROVINCIAL", this.CostoLlamada, this.franjaHoraria);

            return str.ToString();
        }

        public static bool Equals(object obj)
        {
            return obj is Provincial;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
