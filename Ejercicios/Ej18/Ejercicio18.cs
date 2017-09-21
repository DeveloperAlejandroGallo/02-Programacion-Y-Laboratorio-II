using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej18_Class;
using Ej18_Enum;

namespace Ej18
{
    class Ejercicio18
    {
        static void Main(string[] args)
        {
            Computadora compu1 = new Computadora(true, EMarca.Apple, 1.2F, EProcesador.ADM_Semprom_145);

            Console.WriteLine("{0,-10}|{1,-10}|{2,-10}|{3,-10}", "Encendida", "Marca", "Peso", "Procesador");
            compu1.InformarEstado();
            compu1.setPeso(3);
            compu1.Apagar();
            compu1.InformarEstado();
            
            Console.ReadKey();
        }
    }
}
