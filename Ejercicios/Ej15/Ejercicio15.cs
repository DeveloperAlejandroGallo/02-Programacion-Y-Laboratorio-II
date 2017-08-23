using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej12;

namespace Ej15
{
    class Ejercicio15
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 15 - Calcular";

            double nro1, nro2, resultado;
            string operador;

            do
            {
                Console.Clear();
                Console.Write("Ingrese el 1° Nro: ");
                while (!double.TryParse(Console.ReadLine(), out nro1))
                    Console.Write("NO ES UN NRO!\nIngrese el 1° Nro: ");

                Console.Write("Ingrese el 2° Nro: ");
                while (!double.TryParse(Console.ReadLine(), out nro2))
                    Console.Write("NO ES UN NRO!\nIngrese el 2° Nro: ");

                Console.Write("Que operacion desea realizar? (+,-,*,/)? ");
                operador = Console.ReadLine();
                while (!operador.Contains("+") && !operador.Contains("-") && !operador.Contains("*") && !operador.Contains("/"))
                {
                    Console.Write("NO ES UN OPERADOR VALIDO!\nQue operacion desea realizar? (+,-,*,/)? ");
                    operador = Console.ReadLine();
                }

                resultado = Calculadora.Calcular(nro1, nro2, operador);

                Calculadora.Mostrar(resultado);

            } while (ValidarRespuesta.ValidaS_N());
        }
    }
}
