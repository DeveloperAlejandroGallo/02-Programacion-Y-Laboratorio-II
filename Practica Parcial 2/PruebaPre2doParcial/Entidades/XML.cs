using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    public class Archivos<Tipo>
        where Tipo:class, new()
    {
        public static string archivoXML = "courier.xml";
        
        public static bool GuardarXML(Tipo clase)
        {
            try
            { 
                XmlSerializer ser = new XmlSerializer(typeof(Tipo));
                XmlTextWriter write = new XmlTextWriter(archivoXML, Encoding.UTF8);
                ser.Serialize(write, clase);
                write.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new ErrorEnArchivoException();
            }

        }

        public static bool LeerXML(out Tipo clase)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Tipo));
                XmlTextReader read = new XmlTextReader(archivoXML);
                clase = (Tipo)ser.Deserialize(read);
                return true;
            }
            catch
            {
                throw new ErrorEnArchivoException();
            }


        }


    }
}
