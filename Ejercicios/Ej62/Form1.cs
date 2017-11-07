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

namespace Ej62
{
    public partial class frmEj62 : Form
    {
        public frmEj62()
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

        private void frmEj62_Load(object sender, EventArgs e)
        {
            Thread hilito = new Thread(MostrarHora);

            hilito.Start();
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

    }
}
