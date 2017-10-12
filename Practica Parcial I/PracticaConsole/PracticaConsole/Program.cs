using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            short cantidad = 4;
            Queue<int> cola = new Queue<int>();
            Stack<int> pila = new Stack<int>();


            for (int i = 0; i <= cantidad * 2; i += 2)
                cola.Enqueue(i);

            foreach (int i in cola)
                pila.Push(i);

            foreach (int i in pila)
                Console.Write("{0}, ", i);

            Console.ReadKey();


        }
    }
}
