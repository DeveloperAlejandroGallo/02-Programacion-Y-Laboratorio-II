using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej29
{
    public class Equipo
    {
        short cantidadJugadores;

        List<Jugador> jugadores;

        string nombre;

        private Equipo();

        public Equipo(short cantidad, string nombre);

        public static operator +(Equipo e, Jugador j);


    }
}
