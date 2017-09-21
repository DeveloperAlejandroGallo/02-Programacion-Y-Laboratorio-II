using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej16
{
    public class Alumno
    {
        private static int Nota1;

        private static int Nota2;

        private static int NotaFinal;

        string apellido;

        int legajo;

        string nombre;

        public static void Estudiar(int nota1, int nota2)
        {
            Nota1 = nota1;
            Nota2 = nota2;
        }

        public static void CalcularFinal()
        {
            Random random = new Random();

            if (Nota1 >= 4 && Nota2 >= 4)
                NotaFinal = random.Next(4, 10);
            else
                NotaFinal = -1;
        }

        public static void Mostrar()
        {
            Console.WriteLine("\nALUMNO\tNOTA 1\tNOTA 2\tNOTA FINAL");
            Console.Write("{0}\t{1}\t{2}\t",1,Nota1,Nota2);
            if(NotaFinal != -1)
                Console.Write("{0}\n", NotaFinal);


        }

        public static Alumno setDatos(string nombre, string apellido, int legajo)
        {
            Alumno alumno=new Alumno();

            alumno.apellido = apellido;
            alumno.nombre = nombre;
            alumno.legajo = legajo;

            return alumno;
        }


    }
}
