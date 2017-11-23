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
    public partial class frmPpal : Form
    {
        LosHilos hilos;
        static Random cantAleatoria;

        public frmPpal()
        {
            InitializeComponent();
            hilos = new LosHilos();
            cantAleatoria = new Random();
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            try
            {
                hilos = hilos + cantAleatoria.Next(-1, 10);
            }
            catch (CantidadInvalidaException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmPpal_Load(object sender, EventArgs e)
        {
            hilos.AvisoFin += MostrarMensajeFin;
        }

        private void MostrarMensajeFin(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            frmBitacora bitacora = new frmBitacora();
            bitacora.Show();
        }

        private void frmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
