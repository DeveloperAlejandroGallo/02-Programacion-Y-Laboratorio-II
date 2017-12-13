using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Threading;
using System.Xml.Serialization;
using System.Xml;

namespace Recuperatorios2017_AJG
{
    public partial class frmFinal : Form
    {
        MEspecialista medicoEspecialista;
        MGeneral medicoGeneral;
        Thread mocker;
        Queue<Paciente> pacientesEnEspera;

        public frmFinal()
        {
            InitializeComponent();
            pacientesEnEspera = new Queue<Paciente>();
            this.medicoGeneral = new MGeneral("Luis", "Salinas");
            this.medicoEspecialista = new MEspecialista("Jorge", "Iglesias",MEspecialista.Especialidad.Traumatologo);
        }

        private void frmFinal_Load(object sender, EventArgs e)
        {
            mocker = new Thread(MockPacientes);
            mocker.Start();
        }

        private void MockPacientes()
        {
            int nro = 0;
            while(true)
            {
                pacientesEnEspera.Enqueue(new Paciente("Nombre " + nro.ToString(), "Apellido " + nro.ToString()));
                nro++;
                Thread.Sleep(3000);
            }
        }







        #region Serializacion

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            List<Paciente> list = new List<Paciente>();
            list = (List<Paciente>)Convert.ChangeType(pacientesEnEspera, typeof(List<Paciente>));

            XmlTextWriter writer = new XmlTextWriter("pacientes_serialize.xml", Encoding.UTF8);
            XmlSerializer ser = new XmlSerializer(typeof(List<Paciente>));

            ser.Serialize(writer, list);
            writer.Close();
        }
        private void btnDeserializar_Click(object sender, EventArgs e)
        {
            string texto = "";
            List<Paciente> list = new List<Paciente>();
            XmlTextReader reader = new XmlTextReader("pacientes_serialize.xml");
            XmlSerializer ser = new XmlSerializer(typeof(List<Paciente>));
            list = (List<Paciente>)ser.Deserialize(reader);

            foreach (Paciente p in list)
            {
                texto += p.ToString() + "\n";

            }

            MessageBox.Show(texto, "Pacientes DesSerializados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        #endregion

        private void frmFinal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Thread.CurrentThread.IsAlive)
                Thread.CurrentThread.Abort();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            AtenderPacientes(medicoGeneral);
        }


        private void btnEspecialista_Click(object sender, EventArgs e)
        {
            AtenderPacientes(medicoEspecialista);

        }

        private void AtenderPacientes(IMedico iMedico)
        {
            if (pacientesEnEspera.Count > 0)
            {
                Paciente p = pacientesEnEspera.Dequeue();
                iMedico.IniciarAtencion(p);
                FinAtencion(p, (Medico)iMedico);
            }
        }

        private void FinAtencion(Paciente p, Medico m)
        {
            MessageBox.Show(string.Format("Finalizo la Atencion de {0} por {1}!", p.Apellido +", "+p.Nombre, m.Apellido + ", " + m.Nombre), "FIN ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Information );
        }
    }
}
