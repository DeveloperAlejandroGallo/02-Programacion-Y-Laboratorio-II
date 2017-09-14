using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej29
{
    public class Jugador
    {
        long dni;

        string nombre;

        int partdosJugados;

        float promediosDeGoles;

        int totalGoles;

        float GetPromedioGoles();

        private Jugador();

        private Jugador(string nombre);

        private Jugador(string nombre, int totalGoles, int totalPartidos);

        public string MostrarDatos();

        public static operator ==(Jugador j1, Jugador j2);

    }
}
