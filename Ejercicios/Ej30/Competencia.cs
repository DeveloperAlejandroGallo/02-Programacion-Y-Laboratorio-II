using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej30
{
    public class Competencia
    {
        int cantidadDeCompetidores;
        short cantidadDeVueltas;
        List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadDeVueltas, short cantidadDeCompetidores)
            :this()
        {
            this.cantidadDeCompetidores = cantidadDeCompetidores;
            this.cantidadDeVueltas = cantidadDeVueltas;
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if(c.competidores.Count() < c.cantidadDeCompetidores)
            {
                if(!estaCompetidor(c,a))
                {
                    a.EnCompetencia = true;
                    a.VueltasRestantes = c.cantidadDeVueltas;
                    a.CantidadCombustible = (short)new Random().Next(15, 100);  
                    c.competidores.Add(a);
                    return true;
                }
            }
            return false;
        }

        static bool estaCompetidor(Competencia c, AutoF1 a)
        {
            foreach(AutoF1 auto in c.competidores)
            {
                if (auto == a)
                    return true;
            }

            return false;
        }


    }
}
