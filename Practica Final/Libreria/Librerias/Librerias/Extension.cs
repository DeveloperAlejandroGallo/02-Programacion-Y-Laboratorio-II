using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias
{
    public sealed class ClaseSellada
    {
        private int id;
        public ClaseSellada(int id)
        {
            this.id = id;
        }

        public int ID
        {
            get
            {
                return this.id;
            }
        }
    }
    //**************************************************************************//
    public static class ExtensionClaseSellada
    {
        public static string MetodoExtendido(this ClaseSellada miClase, string prefijo)
        {
            return String.Format("{1} <---> {0}", miClase.ID, prefijo);
        }
        public static string MetodoExtendido(this ClaseSellada miClase, string prefijo, string otro)
        {
            return String.Format("{1} <---> {0}", miClase.ID, prefijo);
        }

        public static string MetodoExtendido(this String miClase, string prefijo)
        {
            return String.Format("{1} <---> {0}", prefijo, miClase);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClaseSellada cs = new ClaseSellada(19);
            String s = "Prefijo";

            Console.WriteLine(cs.MetodoExtendido("Sufijo ClaseSellada1", "a"));
            Console.WriteLine(cs.MetodoExtendido("Sufijo ClaseSellada2"));

            Console.WriteLine(s.MetodoExtendido("Sufijo String"));

            Console.ReadKey();
        }
    }
}
