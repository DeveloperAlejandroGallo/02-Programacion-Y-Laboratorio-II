using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ej66
{
    public partial class frmEj66 : Form
    {
        Temporizador temporizador=null;
        public frmEj66()
        {
            InitializeComponent();
        }

        private void frmEj62_Load1(object sender, EventArgs e)
        {

            //this.Show;

            bool pasoUnSeg=true;
            DateTime hora = DateTime.Now;

            while (true)
            {
                if(pasoUnSeg)
                {
                    lblHora.Text = hora.ToString("DD/MM/YYYY HH:mm:ss");
                    pasoUnSeg = false;
                }

                if ((DateTime.Now - hora).TotalMilliseconds >= 1000)
                    pasoUnSeg = true;

            }
        }


        private void frmEj62_Load2(object sender, EventArgs e)
        {
            time.Start();
        }

        private void time_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void frmEj62_Load3(object sender, EventArgs e)
        {
            Thread hilito = new Thread(MostrarHora);

            hilito.Start();
        }

        private void frmEj62_Load(object sender, EventArgs e)
        {
            temporizador = new Temporizador();
            temporizador.EventoTiempo += Temporizador_EventoTiempo;
            //temporizador.Activo = true;
        }
        /// <summary>
        /// Manejador
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        private void Temporizador_EventoTiempo(object obj, EventArgs e)
        {
            MostrarHora2();
        }

        private void MostrarHora()
        {


            bool pasoUnSeg = true;
            DateTime hora = DateTime.Now;

            while (true)
            {
                if (pasoUnSeg)
                {
                    if (lblHora.InvokeRequired)
                    {
                        lblHora.BeginInvoke((MethodInvoker)delegate ()
                        {
                            lblHora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                        }
                        );
                    }
                    else
                    {
                        lblHora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    }
                    pasoUnSeg = false;
                }

                if ((DateTime.Now - hora).TotalMilliseconds >= 1000)
                    pasoUnSeg = true;

                Thread.Sleep(1000);
            }
        }

        private void MostrarHora2()
        {

            DateTime hora = DateTime.Now;
            if (lblHora.InvokeRequired)
            {
                lblHora.BeginInvoke((MethodInvoker)delegate ()
                {
                    lblHora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                }
                );
            }
            else
            {
                lblHora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            }
               
        }

        private void frmEj66_FormClosed(object sender, FormClosedEventArgs e)
        {
            temporizador.KillThread();    
        }
    }
}
