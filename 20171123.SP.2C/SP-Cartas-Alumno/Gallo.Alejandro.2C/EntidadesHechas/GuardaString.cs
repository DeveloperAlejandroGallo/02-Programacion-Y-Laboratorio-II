using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesHechas
{
    public static class GuardaString
    {
        public static bool Guardar(this string texto, string archivo)
        {
            StreamWriter writer = null;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString() + "\\" + archivo;
            try
            {
                if (File.Exists(path))
                    writer = new StreamWriter(path, true);
                else
                    writer = new StreamWriter(path);

                writer.WriteLine(texto);

            }
            catch (Exception e)
            {
                throw new Exception("Error al guardar en " + path, e);
            }
            finally
            { 
                if(!ReferenceEquals(writer,null))
                    writer.Close();
            }
            return true;
        }
    }
}
