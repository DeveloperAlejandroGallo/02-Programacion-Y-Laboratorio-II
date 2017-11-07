using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej58_Entidades;

namespace Ej58
{
    class MainCentralita
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");
            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial("Glew",Provincial.Franja.Franja_3, 55, "CABA");
            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            c = c + l1;
            Console.WriteLine(c.ToString());
            c = c + l2;
            Console.WriteLine(c.ToString());
            c = c + l3;
            Console.WriteLine(c.ToString());
            c = c + l4;
            Console.WriteLine(c.ToString());
            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());
            

            Console.WriteLine("****************LOG*****************");
            Console.WriteLine(c.Leer());

            Console.ReadKey();
        }
    }
}
