using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ej21_Moneda;

namespace Ej23
{
    public partial class frmConversorDinero : Form
    {
        public frmConversorDinero()
        {
            InitializeComponent();
        }

        private void btnConvertEur_Click(object sender, EventArgs e)
        {
            double nro;
            if(double.TryParse(txtEur.Text, out nro))
            {
                Euro eur = new Euro(nro);
                txtEurToEur.Text =  (eur.cantidad * Dolar.getCotizacion()).ToString();
                txtEurToDls.Text =  (eur.cantidad * Euro.getCotizacion()).ToString();
                txtEurToPeso.Text = (eur.cantidad * Euro.getCotizacion() * Peso.getCotizacion()).ToString();

            }
        }

        private void btnConvertDls_Click(object sender, EventArgs e)
        {
            double nro;
            if (double.TryParse(txtEur.Text, out nro))
            {
                Dolar dls = new Dolar(nro);
                txtDlsToEur.Text =  (dls.cantidad * Euro.getCotizacion()).ToString();
                txtDlsToDls.Text =  (dls.cantidad * Dolar.getCotizacion()).ToString();
                txtDlsToPeso.Text = (dls.cantidad * Peso.getCotizacion()).ToString();

            }

        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            double nro;
            if (double.TryParse(txtEur.Text, out nro))
            {
                Peso pes = new Peso(nro);
                txtPesoToEur.Text =  (pes.cantidad * Euro.getCotizacion() * Peso.getCotizacion()).ToString();
                txtPesoToDls.Text =  (pes.cantidad * Peso.getCotizacion()).ToString();
                txtPesoToPeso.Text = (pes.cantidad * Dolar.getCotizacion()).ToString();

            }

        }
    }
}
