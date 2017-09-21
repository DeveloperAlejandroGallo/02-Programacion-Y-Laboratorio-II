using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_RPP_LabII
{
    class Program
    {
        static void Main(string[] args)
        {
            //**Huracán de San Rafael Futbol**
            //Nómina Jugadores:
            //Fernando Pandolfi camiseta número 11
            //Julio Marchant camiseta número 8
            //Ezequiel Medran camiseta número 12
            //José Pereda camiseta número 24
            //Hernán Florentin camiseta número 6
            //Fernando Navas, capitán del equipo, camiseta número 11
            //Dirigido por: Jorge Habbeger


            Jugador j1 = new Jugador("Fernando", "Pandolfi", 11, false);
            Jugador j2 = new Jugador("Julio", "Marchant", 8, false);
            Jugador j3 = new Jugador("Ezequiel", "Medran", 12, false);
            Jugador j4 = new Jugador("José", "Pareda", 24, false);
            Jugador j5 = new Jugador("Hernán", "Florentin", 6, false);
            Jugador j6 = new Jugador("Fernando", "Navas", 10, true);
            Jugador j1bis = new Jugador("Fernando", "Pandolfi", 11, false);

            DirectorTecnico dt = new DirectorTecnico("Jorge", "Herber");

            Equipo equipo = new Equipo("Huracán de San Rafael",dt);

            Console.WriteLine("j1 == j1bis = {0}", j1==j1bis);
            Console.WriteLine("j1 == j2 = {0}\n\n", j1 == j2);

            equipo = equipo + j1;
            equipo = equipo + j2;
            equipo = equipo + j3;
            equipo = equipo + j4;
            equipo = equipo + j5;
            equipo = equipo + j6;
            string s = equipo;
            Console.WriteLine(s);


            Console.ReadKey();

        }
    }
}
