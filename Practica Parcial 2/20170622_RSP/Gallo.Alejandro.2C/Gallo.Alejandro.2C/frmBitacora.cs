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

namespace Gallo.Alejandro._2C
{
    public partial class frmBitacora : Form
    {
        public frmBitacora()
        {
            InitializeComponent();
            LosHilos hilos = new LosHilos();

            rtxBitacora.Text = "";
            rtxBitacora.Text = hilos.Bitacora;
        }
    }
}
