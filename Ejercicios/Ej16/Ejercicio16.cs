using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej16
{
    class Ejercicio16
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno() ;
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();
            string apellido, nombre;
            int legajo, nota1, nota2;

            for(var i=1; i<=3;i++ )
            {
                Console.WriteLine("Ingrese los datos del {0}° alumno:");
                Console.Write("Apellido: ");
                apellido = Console.ReadLine();
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Legajo: ");
                while(!int.TryParse(Console.ReadLine(),out legajo))
                    Console.Write("El legajo debe ser numerico!.\nLegajo: ");
                Console.Write("Nota 1: ");
                while (!int.TryParse(Console.ReadLine(), out nota1))
                    Console.Write("La nota debe ser numerica!.\nNota 1: ");
                Console.Write("Nota 2: ");
                while (!int.TryParse(Console.ReadLine(), out nota2))
                    Console.Write("La nota debe ser numerica!.\nNota 2: ");                

                switch(i)
                {
                    case 1:
                        alumno1 = Alumno.setDatos(nombre, apellido, legajo);
                        break;
                    case 2:
                        alumno2 = Alumno.setDatos(nombre, apellido, legajo);
                        break;
                    case 3:
                        alumno3 = Alumno.setDatos(nombre, apellido, legajo);
                        break;
                }
                Alumno.Estudiar(nota1, nota2);

                Alumno.Mostrar();
                Console.WriteLine("\n");
            }


            Console.ReadKey();
        }
    }
}
