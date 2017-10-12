using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace PrimerParcial
{
    public partial class frmMesa : Form
    {
        public frmMesa()
        {
            InitializeComponent();
        }

        public Mesa nuevaMesa;

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            int a;

            if (int.TryParse(((TextBox)sender).Text, out a))
            {
                nuevaMesa = new Mesa(a);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Hide();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
