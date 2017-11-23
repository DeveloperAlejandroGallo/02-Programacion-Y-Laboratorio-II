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

namespace Corredores
{
    public partial class frmRSP : Form
    {
        static string archivo = "Ganadores.txt";
        public delegate void CorrenCallback(int avance, Corredor corredor);

        List<Persona> corredores;
        List<Thread> corredoresActivos;
        bool hayGanador;


        public frmRSP()
        {
            InitializeComponent();
            this.corredores = new List<Persona>();
            this.corredoresActivos = new List<Thread>();
            this.corredores.Add(new Persona("Fernando", 9, Corredor.Carril.Carril_1));
            this.corredores.Add(new Persona("Alejandro", 9, Corredor.Carril.Carril_2));
            this.hayGanador = false;

            pgbCarril1.Maximum = 100;
            pgbCarril2.Maximum = 100;

        }

        private void frmRSP_Load(object sender, EventArgs e)
        {

        }

        private void AnalizarCarrera(ProgressBar carril, int avance, Corredor corredor)
        {
            if (carril.Value + avance < pgbCarril1.Maximum)
            {
                carril.Value += avance;
            }
            else
                HayGanador(corredor);

        }

        private void btnCorrer_Click(object sender, EventArgs e)
        {
            foreach(Persona p in corredores)
            {
                p.Corriendo += PersonaCorriendo;
                Thread t = new Thread(p.Correr);
                corredoresActivos.Add(t);
                t.Start();
            }
        }

        private void HayGanador(Corredor corredor)
        {
            foreach(Thread hilo in corredoresActivos)
            {
                hilo.Abort();
            }
            hayGanador = true;
            corredor.Guardar(archivo);
            MessageBox.Show(corredor.ToString());
            LimpiarCarriles();
        }

        private void LimpiarCarriles()
        {
            pgbCarril1.Value = 0;
            pgbCarril2.Value = 0;
            corredoresActivos.Clear();
            hayGanador = false;
        }

        private void PersonaCorriendo(int avance, Corredor corredor)
        {
            if (pgbCarril1.InvokeRequired || pgbCarril2.InvokeRequired)
            {
                CorrenCallback d = new CorrenCallback(PersonaCorriendo);
                this.Invoke(d, new object[] { avance, corredor });
            }
            else
            {
                if(!hayGanador)
                {
                    if (corredor.CarrilElegido == Corredor.Carril.Carril_1)
                        AnalizarCarrera(pgbCarril1, avance, corredor);
                    else
                        AnalizarCarrera(pgbCarril2, avance, corredor);
                }

            }
        }
    }
}
