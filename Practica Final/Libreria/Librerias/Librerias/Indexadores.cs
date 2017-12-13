/*
* Created by SharpDevelop.
* User: i.landajuela
* Date: 21/12/2016
* Time: 18:34
*
* To change this template use Tools | Options | Coding | Edit Standard Headers.
*/
using System;

namespace Indexadores
{

    //Ejemplo de uso de descriptores de acceso get/set para controlar
    //el acceso a miembros privados de la clase
    class TimePeriod
    {
        private double _seconds;
        public double Seconds
        {
            get { return _seconds; }
            set { _seconds = value; }
        }
    }

    //-----------------------------------------------------------------

    public class clsCaja
    {
        private string[] nombres = { "longitud", "altura", "anchura" };
        private double[] medidas = new double[3];

        public clsCaja(double longitud, double anchura, double altura)
        {
            medidas[0] = longitud;
            medidas[1] = anchura;
            medidas[2] = altura;
        }

        //indexador para acceder a medidas por el número de indice entero
        public double this[int indice]
        {
            get
            {
                //valida indice a obtener
                if ((indice < 0) || (indice >= medidas.Length))
                {
                    return -1;
                }
                else
                    return medidas[indice];
            } //fin get
            set
            {
                if (indice >= 0 && indice < medidas.Length)
                    medidas[indice] = value;
            } //fin set

        } // fin de indexador numérico

        public double this[string nombre]
        {
            get
            {
                //localiza elemento a obtener
                int i = 0;
                while ((i < nombres.Length) && (nombre != nombres[i]))
                    i++;
                return (i == nombres.Length) ? -1 : medidas[i];
            }
            set
            {
                int i = 0;
                while ((i < nombres.Length) && (nombre != nombres[i]))
                    i++;
                if (i != nombres.Length)
                    medidas[i] = value;
            }
        } //fin de indexador string

    }


    class Program
    {
        public static void Main(string[] args)
        {
            clsCaja objCaja = new clsCaja(10, 20, 30);


            objCaja[0] = 80;
            Console.WriteLine("caja[\"longitud\"]={0}", objCaja["longitud"]);
            objCaja["longitud"] = 90;
            Console.WriteLine("caja[\"longitud\"]={0}", objCaja["longitud"]);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}