using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ej07
{
    class Ejercicio07
    {
        static void Main(string[] args)
        {
            string fechaNac;
            int dia, mes, anio, diasVividos;

            Console.Title = "Ejercicio Nro 07";
            Console.WriteLine("Fecha Actual: {0,2:0#}/{1,2:0#}/{2}", DateTime.Now.Day,DateTime.Now.Month, DateTime.Now.Year);
            Console.Write("Ingrese su fecha de nacimiento(DD/MM/AAAA): ");
            fechaNac = Console.ReadLine();

            if (int.TryParse(fechaNac.Substring(0, 2), out dia)
                && int.TryParse(fechaNac.Substring(3, 2), out mes)
                && int.TryParse(fechaNac.Substring(6, 4), out anio))
            {
                diasVividos = cuantosDiasVividos(dia, mes, anio);
                Console.WriteLine("DIAS VIVIDOS: {0}", diasVividos);
            }
            else
                Console.WriteLine("FECHA DE NACIMIENTO ERRONEA");

            Console.ReadKey();

        }

        private static int cuantosDiasVividos(int dia, int mes, int anio)
        {
            int diaActual = DateTime.Now.Day;
            int mesActual = DateTime.Now.Month;
            int anioActual = DateTime.Now.Year;
            int dias = 0;
            double calculo;

            calculo = ((anioActual - anio) * (365.242189)) + ((diaActual - dia) + ((mesActual - mes) * (365.242189 / 12)));

            dias = (int)Math.Truncate(calculo);

            return dias;
        }



        static bool esBisiesto(int anio)
        {
            bool result = false;

            if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 4 == 0 && anio % 100 == 0 && anio % 400 == 0))
                result = true;

            return result;
        }


    }
}
