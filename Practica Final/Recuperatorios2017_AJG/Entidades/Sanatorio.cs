using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Sanatorio
    {
        MEspecialista medicoEspecialista;
        MGeneral medicoGeneral;
        Queue<Paciente> pacientesEnEspera;
        int turnosTotales;

        private Sanatorio()
        {
            this.medicoGeneral = new MGeneral("Luis", "Salinas");
            this.medicoEspecialista = new MEspecialista("Jorge", "Iglesias",MEspecialista.Especialidad.Traumatologo);

        }

        public Sanatorio(int cantidadDeTurnos)
            :this()
        {
            this.turnosTotales = cantidadDeTurnos;
            pacientesEnEspera = new Queue<Paciente>();
        }

        private static void TomarDatos(Persona p)
        {

            XmlTextWriter writer = new XmlTextWriter(p.Nombre+"."+p.Apellido+".xml", Encoding.UTF8);
            XmlSerializer ser = new XmlSerializer(typeof(Paciente));

            ser.Serialize(writer, p);
            writer.Close();
        }


        public static Queue<Paciente> operator +(Sanatorio s, Paciente p)
        {
            if (s.turnosTotales > 0)
                s.pacientesEnEspera.Enqueue(p);
            else
                TomarDatos(p);

            return s.pacientesEnEspera;
        }
    }
}
