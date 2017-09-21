using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej40_Entidades
{
    public abstract class Llamada
    {
        #region Enums
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        } 
        #endregion

        #region Atributos
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen; 
        #endregion

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

        public abstract float CostoLlamada
        { 
            get;
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


        protected virtual string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            //str.Append("LLAMADAS---->\n\n");
            //str.AppendFormat("{0,-10}|{1,-10}|{2,-10}|{3,-10}|{4,-10}|{5,-10}\n", "DURACION", "DESTINO", "ORIGEN", "TIPO", "COSTO", "FRANJA");
            str.AppendFormat("{0,-10}|{1,-10}|{2,-10}", this.Duracion, this.NroDestino, this.NroOrigen);

            return str.ToString();
        }

        public static bool operator ==(Llamada llamada1, Llamada llamada2)
        {
            
            return (llamada1.Equals(llamada2)) & llamada1.NroDestino == llamada2.NroDestino & llamada1.NroOrigen == llamada2.NroOrigen;
        }

        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            return !(llamada1 == llamada2);
        }
        #endregion Metodos


    }
}
