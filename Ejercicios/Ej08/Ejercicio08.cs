using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 08. Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas en el mes 
 * de 'n' empleados de una fábrica.
 * Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas),
 * hay que sumarle la cantidad de años trabajados multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto 
 * de descuentos. Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto, 
 * el total de descuentos y el valor neto a cobrar de todos los empleados ingresados. Nota: Utilizar estructuras repetitivas y selectivas.
 */

namespace Ej08
{
    class Ejercicio08
    {
        struct Empleado
        {
            string Nombre;
            int hsTrabajadas;
            int aniosTrabajados;
        }
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 08";
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            int cantEmpleados;
            char continuar;

            Console.Write("Ingrese la cantidad de maxima a cargar: ");
            Console.ReadLine();
        
            do
            {
                Empleado empleado = new Empleado();
                Console.Clear();
                Console.Write("Ingrese el nombre del Empleado: ");
                Console.ReadLine();

                Console.WriteLine("Presione s para continuar");
                continuar = Console.ReadKey().KeyChar;
            }while(continuar.ToString().ToUpper() == "S");



            Console.ReadKey();
        }
    }
}
