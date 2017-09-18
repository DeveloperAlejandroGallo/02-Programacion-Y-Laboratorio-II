using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej37_Entidades
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
        
        public float CostoLlamada
        {
            get 
            {
                return (float)((int)this.franjaHoraria / 100);
            }
        }

        #endregion

        #region Constructores

        public Provincial(Franja miFranja, Llamada llamada)
            : base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) 
            : this(miFranja, new Llamada(duracion,destino,origen))
        {

        }
        #endregion

        #region Metodos

        private float CalcularCosto()
        {
            return this.CostoLlamada * base.Duracion;
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0,-10}|{1,-10}|{2,-10}|{3,-10}|{4,-10}|{5,-10}\n", "PROVINCIAL", base.Duracion, base.NroDestino, base.NroOrigen, this.CostoLlamada, this.franjaHoraria);

            return str.ToString();
        }

        #endregion
    }
}
