using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej37_Entidades
{
    public class Local : Llamada
    {
        protected float costo;

        #region Prop
        public float CostoLlamada
        {
            get { return CalcularCosto(); }
        }
        #endregion

        #region Constructores
        public Local(Llamada llamada, float costo)
            : base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo) 
            : this(new Llamada(duracion, destino, origen), costo)
        {
        
        }
        #endregion

        #region Metodos
        public void Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.Append("LLAMADA\n\n");
            str.AppendFormat("{0,-10}|{1,-10}|{2,-10}|{3,-10}\n", "DURACION", "DESTINO", "ORIGEN", "COSTO");
            str.AppendFormat("{0,-10}|{1,-10}|{2,-10}|{3,-10}\n", base.Duracion, base.NroDestino, base.NroOrigen, this.CostoLlamada);
        }

        private float CalcularCosto()
        {
            return (base.Duracion * this.CostoLlamada);
        }
        
        #endregion




    }
}
