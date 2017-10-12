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
    public partial class frmPrincipal : Form
    {
        List<Mesa> mesas;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            mesas = new List<Mesa>();
        }

        private void cargarMesas()
        {
            cmbMesas.Items.Clear();
            foreach (Mesa item in this.mesas)
            {
                cmbMesas.Items.Add(item.Numero);
            }
            this.cargarComensales();

        }

        private void btnMesa_Click(object sender, EventArgs e)
        {

            frmMesa formMesa = new frmMesa();
            if (formMesa.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bool existe = false;
                foreach (Mesa miMesa in mesas)
                {
                    if (formMesa.nuevaMesa == miMesa)
                        existe = true;
                }
                if (existe)
                    MessageBox.Show("La Mesa ya existe");
                else
                    this.mesas.Add(formMesa.nuevaMesa); //Correccion
            }

            this.cargarMesas();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.cmbMesas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una mesa");
            }
            else
            {
                frmComensal formComensal = new frmComensal();
                if (formComensal.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    if (formComensal.nuevoComensal is Mayor)
                        this.mesas[this.cmbMesas.SelectedIndex] += (Mayor)formComensal.nuevoComensal;
                    else
                        this.mesas[this.cmbMesas.SelectedIndex] += (Menor)formComensal.nuevoComensal;
                this.cargarComensales();
            }
        }

        private void cargarComensales()
        {
            lstComensales.Items.Clear();
            if (this.cmbMesas.SelectedIndex != -1)
            {
                foreach (Comensal c in this.mesas[this.cmbMesas.SelectedIndex].Comensales)
                {
                    lstComensales.Items.Add(c.ToString());
                }
            }
        }

        private void cmbMesas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cargarComensales();
        }
    }
}
