using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_RPP_LabII
{
    public class Equipo 
    {
        #region Enum
        public enum Deportes
        {
            Basquet,
            Futbol,
            Handball,
            Rugby
        }
        
        #endregion

        #region Fields
        static Deportes deporte;
        DirectorTecnico dt;
        List<Jugador> jugadores;
        string nombre;
        
        #endregion


        #region Propiedades
        public Deportes Deporte
        {
            set 
            { 
                deporte = value; 
            }
        } 
        #endregion


        #region Constructores
        static Equipo()
        {
            deporte = Deportes.Futbol;
        }

        private Equipo()        
        {
           
            jugadores = new List<Jugador>();
        }

        public Equipo(string nombre, DirectorTecnico dt) : this()
        {
            this.nombre = nombre;
            this.dt = dt;
        }

        public Equipo(string nombre, DirectorTecnico dt, Deportes deporte) 
            : this(nombre, dt)
        {
            this.Deporte = deporte;
        }

        #endregion

        #region Metodos
        
        public static implicit operator string(Equipo equipo)
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("**{0}**\n", equipo.nombre);
            str.AppendLine("NOMINA DE JUGADORES");
            
            foreach(Jugador jugador in equipo.jugadores)
            {
                str.AppendLine(jugador.ToString());
            }

            str.AppendFormat("Dirigido Por {0}", equipo.dt.ToString());
            return str.ToString();
        }


        public static bool operator ==(Equipo e, Jugador j)
        {
            bool ret = false;

            foreach(Jugador auxJugador in e.jugadores)
            {
                if(auxJugador == j)
                {
                    ret = true;
                    break;
                }
            }

            return ret;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j)
                e.jugadores.Add(j);

            return e;

        }

        public static Equipo operator -(Equipo e, Jugador j)
        {
            if (e == j)
                e.jugadores.Remove(j);

            return e;

        }


        #endregion

    }
}
