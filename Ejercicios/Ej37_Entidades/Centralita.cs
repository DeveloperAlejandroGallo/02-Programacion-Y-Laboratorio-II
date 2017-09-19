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
            get
            {
                return listaDeLlamadas;
            }
        }


        #endregion

        #region Constructores

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }


        #endregion



        #region Metodos

        private float CalcularGanancia(Llamada.TipoLlamada tipoLlamada)
        {
            float calculo=0, calculoLocal = 0, calculoProvincial = 0;

            foreach(Llamada call in listaDeLlamadas)
            {
                if (call is Local)
                    calculoLocal+=((Local)call).CostoLlamada;
                else
                    calculoProvincial += ((Provincial)call).CostoLlamada;
            }

            switch(tipoLlamada)
            {
                case Llamada.TipoLlamada.Local:
                    calculo = calculoLocal;
                    break;
                case Llamada.TipoLlamada.Provincial:
                    calculo = calculoProvincial;
                    break;
                case Llamada.TipoLlamada.Todas :
                    calculo = calculoProvincial +  calculoLocal;
                    break;

                    
            }

            return calculo;
                
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.Append("****************************CENTRALITA****************************\n\n");
            str.AppendFormat("RAZON SOCIAL: {0}\n", this.razonSocial);
            str.AppendFormat("GANANCIA TOTAL: {0}\n", CalcularGanancia(Llamada.TipoLlamada.Todas));
            str.AppendFormat("GANANCIA LOCAL: {0}\n", CalcularGanancia(Llamada.TipoLlamada.Local));
            str.AppendFormat("GANANCIA PROVINCIAL: {0}\n", CalcularGanancia(Llamada.TipoLlamada.Provincial));
            str.Append("LLAMADAS---->\n\n");
            str.AppendFormat("{0,-10}|{1,-10}|{2,-10}|{3,-10}|{4,-10}|{5,-10}\n", "TIPO", "DURACION", "DESTINO", "ORIGEN", "COSTO", "FRANJA");
            foreach (Llamada call in listaDeLlamadas)
            {
                if (call is Local)
                     str.Append(((Local)call).Mostrar());
                else
                    str.Append(((Provincial)call).Mostrar());
            }

            return str.ToString();

        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        #endregion 
    }
}
