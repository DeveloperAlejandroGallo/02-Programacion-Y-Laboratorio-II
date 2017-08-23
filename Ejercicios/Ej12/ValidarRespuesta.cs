using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej12
{
    public class ValidarRespuesta
    {
        public static bool ValidaS_N()
        {
            char resp;
            bool ret = false;

            Console.WriteLine("Desea continuar? (s/n)");
            resp = Console.ReadKey().KeyChar;
            while (resp.ToString().ToUpper() != "S" && resp.ToString().ToUpper() != "N")
            {
                Console.WriteLine("\nRESPUESTA INCORRECTA.- Desea continuar? (s/n)");
                
                resp = Console.ReadKey().KeyChar;
            }
           

            if(resp.ToString().ToUpper() == "S")
            {
                ret = true;
            }

            return ret;
        }
    }
}
