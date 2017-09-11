using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej21_Moneda;

namespace Ej27
{
    class Ejercicio27
    {
        static void Main(string[] args)
        {
            List<int> iList1 = new List<int>() { -5, 22, 33, 12, 67, -56, 89, -222, 333, 412, 567, -656, 789, 11, 17, 557, 987, 122, 323, 22345 };
            List<int> iListPos = new List<int>();
            List<int> iListNeg = new List<int>();
            Stack<int> iPila = new Stack<int>();
            Stack<int> iPilaPos = new Stack<int>();
            Stack<int> iPilaNeg = new Stack<int>();
            Queue<int> iCola = new Queue<int>();
            Queue<int> iColaPos = new Queue<int>();
            Queue<int> iColaNeg = new Queue<int>();
            Queue<Dolar> dolarCola = new Queue<Dolar>();

            dolarCola.OrderBy(dolar => dolar.cantidad);

            Console.WriteLine("######LISTAS:######\n");
            Console.WriteLine("LISTA:");
            foreach (var nro in iList1)
            {
                Console.Write(nro);
                Console.Write(iList1.IndexOf(nro) == iList1.Count - 1 ? ".\n\n" : ", ");
                iPila.Push(nro);
                iCola.Enqueue(nro);
               
            }

            iList1.Sort();

            Console.WriteLine("LISTA < a >:");
            foreach (var nro in iList1)
            {
                Console.Write(nro);
                Console.Write(iList1.IndexOf(nro) == iList1.Count - 1 ? ".\n\n" : ", ");
                if (nro > 0)
                    iListPos.Add(nro);
                else
                    iListNeg.Add(nro);
            }
            
            iCola.OrderBy(x => x);

            Console.WriteLine("\n\n######LISTAS:######\n");
            Console.WriteLine("Elementos en la PILA");
            while(iPila.Count() > 0)
            {
                Console.Write(iPila.Pop() + ", ");
            }

            Console.WriteLine("\n\n######COLAS:######\n");
            Console.WriteLine("Elementos en la COLA");
            while (iCola.Count() > 0)
            {
                Console.Write(iCola.Dequeue() + ", ");
            }

            Console.ReadKey();
            Console.Clear();

        }
    }
}
