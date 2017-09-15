using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej37_Entidades
{
    public class Centralita
    {
        List<Llamada> listaDeLlamadas;

        protected string razonSocial;

        #region Propiedades

        public float GananciasPorLocal
        {
            get 
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {

        }


        #endregion

        #region Metodos

        private float CalcularGanancia(Llamada.TipoLlamada tipoLlamada)
        {
            float calculo = 0;

            foreach(Llamada call in listaDeLlamadas)
            { 
                switch (tipoLlamada)
                {
                    case Llamada.TipoLlamada.Local:
                        calculo += ((Local)call).CostoLlamada;
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        calculo += ((Provincial)call).CostoLlamada;
                        break;
                    case Llamada.TipoLlamada.Todas:
                        calculo += ((Local)call).CostoLlamada + ((Provincial)call).CostoLlamada;
                        break;
                }
            }

            return calculo;
                
        }

        public void Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.Append("CENTRALITA:\n\n");
            str.AppendFormat("RAZON SOCIAL: {0}", this.razonSocial);
            str.AppendFormat("GANANCIA TOTAL: {0}", CalcularGanancia(Llamada.TipoLlamada.Todas));
            str.AppendFormat("GANANCIA LOCAL: {0}", CalcularGanancia(Llamada.TipoLlamada.Local));
            str.AppendFormat("GANANCIA PROVINCIAL: {0}", CalcularGanancia(Llamada.TipoLlamada.Provincial));

            foreach (Llamada call in listaDeLlamadas)
            {
                switch ()
                {
                    case Llamada.TipoLlamada.Local:
                        calculo += ((Local)call).CostoLlamada;
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        calculo += ((Provincial)call).CostoLlamada;
                        break;
                    case Llamada.TipoLlamada.Todas:
                        calculo += ((Local)call).CostoLlamada + ((Provincial)call).CostoLlamada;
                        break;
                }
            }
        }
        #endregion 
    }
}
