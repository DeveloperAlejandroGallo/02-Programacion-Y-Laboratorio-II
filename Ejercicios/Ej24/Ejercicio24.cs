using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej24
{
    public class Ejercicio24
    {
        static void Main(string[] args)
        {
            int[] vectorA = new int[10];
            int[] vectorB = new int[10];
            int[] vectorC = new int[10];
            Random nro = new Random();

            Console.WriteLine(string.Format("{0,-10}\t{1,-10}\t{2,-10}", "VECTOR A", "VECTOR B", "VECTOR C"));
            for(var i= 0; i < 10 ; i++)
            {
                vectorA[i]=nro.Next();
                vectorB[i]=nro.Next();
                vectorC[i] = vectorA[i] < vectorB[i] ? vectorA[i] : vectorB[i];
                Console.WriteLine(string.Format("{0,-10}\t{1,-10}\t{2,-10}", vectorA[i], vectorB[i], vectorC[i]));
            }
            Console.WriteLine();
            Burbujeo(vectorC, true);
            Console.WriteLine("Vector C Orden ASC: ");
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(vectorC[i].ToString());
            }
            Console.WriteLine();
            
            Burbujeo(vectorC, false);
            Console.WriteLine("Vector C Orden DESC: ");
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(vectorC[i].ToString());
            }
            Console.WriteLine();

            Console.ReadKey();
            
        }

        static void Burbujeo(int[] vector, bool asc)
        {
            int aux;

            for(var i=0 ; i<vector.Length - 1; i++)
            {
                for(var j=i+1; j< vector.Length ; j++)
                {
                    if(asc)
                    {
                        if(vector[i] > vector[j])
                        {
                            aux = vector[i];
                            vector[i] = vector[j];
                            vector[j] = aux;
                        }
                    }
                    else
                    {
                        if (vector[i] < vector[j])
                        {
                            aux = vector[i];
                            vector[i] = vector[j];
                            vector[j] = aux;
                        }

                    }
                }
            }
        }
    }
}
