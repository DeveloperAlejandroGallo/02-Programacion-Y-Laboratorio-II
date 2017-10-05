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
    public partial class frmComensal : Form
    {
        public Comensal nuevoComensal { get; set; }
        public frmComensal()
        {
            InitializeComponent();
        }

        private void frmComensal_Load(object sender, EventArgs e)
        {
            cargarBebidas();
        }

        private void cargarBebidas(){
            cmbEnum.Items.Clear();
            foreach (Mayor.eBebidas item in Enum.GetValues(typeof(Mayor.eBebidas)))
            {
                cmbEnum.Items.Add(item);
            }
        }

        private void cargarMenu()
        {
            cmbEnum.Items.Clear();
            foreach (Menor.eMenu item in Enum.GetValues(typeof(Menor.eMenu)))
            {
                cmbEnum.Items.Add(item);
            }
        }

        private void rdoMenor_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                cargarMenu();
                lblEnum.Text = "Menu";
            }
            else
            {
                cargarBebidas();
                lblEnum.Text = "Bebida";
            }
        }

        private void ctnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rdoMayor.Checked)
            {
                this.nuevoComensal = new Mayor(this.txtNombre.Text, this.txtApellido.Text, (Mayor.eBebidas)cmbEnum.SelectedItem);
            }
            else
            {
                this.nuevoComensal = new Menor(this.txtNombre.Text, this.txtApellido.Text, (Menor.eMenu)cmbEnum.SelectedItem);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Hide();
        }

    }
}
