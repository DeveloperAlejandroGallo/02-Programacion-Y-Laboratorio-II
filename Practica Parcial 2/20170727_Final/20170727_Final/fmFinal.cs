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

namespace _20170727_Final
{
    public partial class fmFinal : Form
    {
        MEspecialista medicoEspecialista;
        MGeneral medicoGeneral;
        Thread mocker;
        Queue<Paciente> pacientesEnEspera;

        
        public fmFinal()
        {
            InitializeComponent();
            this.medicoGeneral = new MGeneral("Luis", "Salinas");
            this.medicoEspecialista = new MEspecialista("Jorge", "Iglesias", MEspecialista.Especialidad.Traumatologo);
            pacientesEnEspera = new Queue<Paciente>();
            medicoEspecialista.AtencionFinalizada += FinAtencion;
            medicoGeneral.AtencionFinalizada +=  FinAtencion;

        }

        
        private void fmFinal_Load(object sender, EventArgs e)
        {
            mocker = new Thread(MockPacientes);
            mocker.Start();

        }


        private void fmFinal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Para verificar si no es null previamente
            if (!object.ReferenceEquals(mocker,null) && mocker.IsAlive)
                mocker.Abort();
        }
    
        private void MockPacientes()
        {
            int i=0;
            while(i < 1000)
            {
                
                pacientesEnEspera.Enqueue(new Paciente("Nombre "+i, "Apellido "+i));
                MessageBox.Show("Paciente Agregado: Nombre " + i + ", Apellido " + i);
                Thread.Sleep(5000);
                i++;
            }
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
                iMedico.IniciarAtencionPaciente(pacientesEnEspera.Dequeue());
            }
            else
                MessageBox.Show("No hay pacientes para atender");
        }

        private void FinAtencion(Paciente p, Medico m)
        {
            if (!object.ReferenceEquals(p, null) && !object.ReferenceEquals(m, null))
                MessageBox.Show(string.Format("Finalizó la atención de {0} por {1}!", p.ToString(), m.ToString()));
            else
                MessageBox.Show("No se pudo atender","Error", MessageBoxButtons.OK);
        }
    }
}
