using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_20171003
{
    class Program
    {
        static void Main(string[] args)
        {
            Mesa mesa = new Mesa(1);
            Menor men1 = new Menor("Ale", "Lito", Menor.EMenu.Hambuergesa);
            Menor men2 = new Menor("Lea", "Lin", Menor.EMenu.Milanesa);
            Mayor may1 = new Mayor("Alguien", "Mayor", Mayor.EBebida.Vino);
            Mayor may2 = new Mayor("Alguien2", "Mayor1", Mayor.EBebida.Agua);
            Mayor may3 = new Mayor("Alguien3", "Mayor2", Mayor.EBebida.Cerveza);

            mesa += men1;
            mesa += men2;
            mesa += may1;
            mesa += may2;
            mesa += may3;
            mesa += men1;

            Console.WriteLine((string)mesa);
            Console.ReadKey();

            
        }
    }
}
