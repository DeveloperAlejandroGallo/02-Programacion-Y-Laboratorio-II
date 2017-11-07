using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej36
{
    public class VehiculoDeCarrera
    {
        #region Atributos
        short cantidadCombustible;
        bool enCompetencia;
        string escuderia;
        short numero;
        short vueltasRestantes;
        #endregion

        #region Constructor
        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.cantidadCombustible = 0;
            this.enCompetencia = false;
            this.vueltasRestantes = 0;
            this.numero = numero;
            this.escuderia = escuderia;
        }
        #endregion

        #region Propiedades
        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }

        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }

        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }

        }

        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }

        #endregion

        public string MostrarDato()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine("Auto F1:");
            str.AppendFormat("CantidadCombustible: {0}\n", this.cantidadCombustible);
            str.AppendFormat("EnCompetencia: {0}\n", this.enCompetencia);
            str.AppendFormat("Escuderia: {0}\n", this.escuderia);
            str.AppendFormat("Numero: {0}\n", this.numero);
            str.AppendFormat("VueltasRestantes: {0}\n", this.vueltasRestantes);

            return str.ToString();


        }

        public static bool operator ==(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            return a1.numero == a2.numero && a1.escuderia == a2.escuderia;
        }

        public static bool operator !=(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            return !(a1 == a2);
        }

        
    }
}
