using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej42
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.InnerException);
            }

        }
    }
}
