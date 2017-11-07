using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej36
{
    public class Competencia
    {
        int cantidadDeCompetidores;
        short cantidadDeVueltas;
        List<VehiculoDeCarrera> competidores;

        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadDeVueltas, short cantidadDeCompetidores)
            :this()
        {
            this.cantidadDeCompetidores = cantidadDeCompetidores;
            this.cantidadDeVueltas = cantidadDeVueltas;
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera a)
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

        static bool estaCompetidor(Competencia c, VehiculoDeCarrera a)
        {
            foreach(VehiculoDeCarrera auto in c.competidores)
            {
                if (auto == a)
                    return true;
            }

            return false;
        }


    }
}
