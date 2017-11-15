using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escriba el primer número");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("Escriba el segundo número");
                int j = int.Parse(Console.ReadLine());
                Console.WriteLine("Resultado = " + dividir(i, j));

                Console.ReadKey();
            }
            catch (OverflowException e)
            {
                Console.WriteLine("En Main Overflow =>" + e.Message);
                Console.ReadKey();
            }
            catch (CocoException e)
            {
                Console.WriteLine("Coco Exception Nenenenenennn =>" + e.Message);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("En Main =>" + e.Message);
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("Finally MAin");
                Console.ReadKey();
            }

        }

        static float dividir(int i, int j)
        {
            float k=0f;
            try
            {
                k= dividir2(i, j);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("En dividir =>"+ e.Message);
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("Finally dividir");
            }

            return k;
        }

        static float dividir2(int i, int j)
        {
            float k = 0f;
            try
            {
                if (j == 0)
                    throw new CocoException("El segundo nro es cero papu", new Exception());

                k=i/j;
            }
            catch (OverflowException e)
            {
                Console.WriteLine("En dividir2 =>" + e.Message);
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("Finally dividir2");
            }

            return k;
        }
    }
}
