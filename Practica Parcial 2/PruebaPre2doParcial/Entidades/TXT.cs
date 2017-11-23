using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class TXT
    {

        public static string archivoTXT = "courier.txt";



        public static bool GuardarTxt(string datos)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(archivoTXT, true))
                {
                    file.WriteLine(datos);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }


        public static bool LeerTxt(out List<string> datos)
        {
            try
            {
                datos = new List<string>();
                using (StreamReader file = new StreamReader(archivoTXT))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                        datos.Add(line);

                    return true;
                }
            }
            catch
            {
                datos = default(List<string>);
                return false;
            }
        }


    }
}
