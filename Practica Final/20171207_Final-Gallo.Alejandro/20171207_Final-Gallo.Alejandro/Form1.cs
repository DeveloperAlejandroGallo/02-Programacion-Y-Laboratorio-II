using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesPP;
using System.Threading;

namespace _20171207_Final_Gallo.Alejandro
{
    public partial class Form1 : Form
    {
        private List<Base> listaElementos;

        public Form1()
        {
            InitializeComponent();
            listaElementos = new List<Base>();
            Base.EventoBase += Manejador_Evento;
        }

        private void Manejador_Evento(List<Base> list)
        {
            string datos="Cargados con el Evento:\n";
            foreach(Base a in list)
            {
                datos += a.MostrarVersion() + "\n";
            }
            CargarRichTextBox(datos);
        }

        private void btnPunto1_Click(object sender, EventArgs e)
        {
            Base derUno1 = new DerivadaUno(10, 11, 12);
            DerivadaUno derUno2 = new DerivadaUno(1, 2, 3);
            Base derDos1 = new DerivadaDos();

            listaElementos.Add(derUno1);
            listaElementos.Add(derUno2);
            listaElementos.Add(derDos1);
            // Generar el código para obtener todos los datos de los elementos de la lista 
            //y luego utilizar CargarRichTextBox para mostrarlos
            string auxiliar = "";

            foreach(Base b in listaElementos)
            {
                auxiliar += b.MostrarVersion() + "\n";
            }

            this.CargarRichTextBox(auxiliar);

        }

        private void btnPunto2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para primer parcial", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnPunto3_Click(object sender, EventArgs e)
        {

        }

        private void btnPunto4_Click(object sender, EventArgs e)
        {
            
            Thread hilo = new Thread(EjecutarEventoThread);
            hilo.Start();
        }

        private void EjecutarEventoThread()
        {
            Base.EjecutarEvento(listaElementos);
        }

        private void btnPunto5_Click(object sender, EventArgs e)
        {

        }

        delegate void CargarRichTextBoxCallback(string datos);
        private void CargarRichTextBox(string datos)
        {
            if(rtbTextoSalida.InvokeRequired)
            {
                CargarRichTextBoxCallback d = new CargarRichTextBoxCallback(CargarRichTextBox);
                this.Invoke(d, new object[] { datos });
            }
            else
                rtbTextoSalida.Text = datos;
        }
    }
}
