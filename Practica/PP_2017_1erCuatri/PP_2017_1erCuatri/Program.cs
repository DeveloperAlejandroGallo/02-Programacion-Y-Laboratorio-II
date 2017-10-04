using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_2017_1erCuatri
{
    class Program
    {
        static void Main(string[] args)
        {
            Grupo miManada = new Grupo("Río Unica", TipoManada.Mixta);
            Perro p1 = new Perro("Moro", "Pitbull");
            Perro p2 = new Perro("Julio", "Cruza", 13, false);
            Perro p3 = new Perro("Ramón", "Salchicha", 2, true);
            Gato g1 = new Gato("Jose", "Angora");
            Gato g2 = new Gato("Hernan", "Cruza");
            Gato g3 = new Gato("Fer", "Siames");

            miManada += p1;
            miManada += p2;
            miManada += p3;
            miManada += g1;
            miManada += g2;
            miManada += g3;

            Console.WriteLine((string)miManada);

            Console.ReadKey();
            
        }
    }
}
