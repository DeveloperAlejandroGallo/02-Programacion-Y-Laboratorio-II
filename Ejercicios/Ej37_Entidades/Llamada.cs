using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej37_Entidades
{
    public class Llamada
    {
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #region Propiedades
        public float Duracion
        {
            get { return this.duracion; }
        }

        public string NroDestino
        {
            get{return nroDestino;}
        }

        public string NroOrigen
        {
            get {return nroOrigen;}
        }

        #endregion Propiedades

        #region Constructores

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;

        }

        #endregion Constructores

        
        #region Metodos

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int orden=0;
            if (llamada1.Duracion > llamada2.Duracion)
                orden = 1;
            else
                if (llamada1.Duracion < llamada2.Duracion)
                    orden = -1;
                
            return orden;
        }


        public void Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.Append("LLAMADAS\n\n");
            str.AppendFormat("{0,-10}|{1,-10}|{2,-10}\n","DURACION","DESTINO","ORIGEN");
            str.AppendFormat("{0,-10}|{1,-10}|{2,-10}\n", this.Duracion, this.NroDestino, this.NroOrigen);
        }

        #endregion Metodos


    }
}
