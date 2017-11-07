using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ej58_Entidades
{   

    public class Local : Llamada , IGuardar<Local>
    {
        public const string archivoXML = "XMLLocal.xml";

        protected float costo;

        #region Prop
        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }
        #endregion

        #region Constructores
        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
            
        }

        public Local(string origen, float duracion, string destino, float costo) 
            : base(duracion,destino,origen)
        {
            this.costo = costo;
        }
        #endregion

        #region Metodos
        protected override string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0}|{1,-10}|{2,-10}\n", base.Mostrar(), "LOCAL", this.CostoLlamada);

            return str.ToString();
        }

        private float CalcularCosto()
        {
            return (base.Duracion * this.costo);
        }
        

        public static bool Equals(object obj)
        {
            return obj is Local;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        //sobreescritura de metodos de interface

        public bool Guardar()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Local));
                XmlTextWriter writer = new XmlTextWriter(archivoXML, Encoding.UTF8);
                serializer.Serialize(writer, this);
                writer.Close();

            }
            catch(Exception e)
            {
                throw new XMLException("Error al serializarXML", typeof(Local).Name, "Guardar");
            }
            return true;
        }

        public Local Leer()
        {
            Local datos;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Local));
                XmlTextReader reader = new XmlTextReader(archivoXML);
                datos = (Local)serializer.Deserialize(reader);
                reader.Close();

            }
            catch (Exception )
            {
                throw new InvalidCastException();
            }
            return datos;
        }

        #endregion




    }
}
