using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej66
{
    public partial class frmEj60 : Form
    {
        public frmEj60()
        {
            InitializeComponent();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            PersonaDAO consulta = new PersonaDAO();
            List<Persona> personas = consulta.Leer();
            lstPersonas.Items.Clear();
            foreach (Persona p in personas)
                lstPersonas.Items.Add(p);

            txtNombre.Text = "";
            txtApellido.Text = "";

            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void lstPersonas_DoubleClick(object sender, EventArgs e)
        {
            if (lstPersonas.SelectedIndex != -1)
            {

                Persona p;
                PersonaDAO consulta = new PersonaDAO();
                p = consulta.LeerPorID(((Persona)lstPersonas.Items[lstPersonas.SelectedIndex]).ID);
                txtApellido.Text = p.Apellido;
                txtNombre.Text = p.Nombre;
            }
            else
                MessageBox.Show("Debe seleccionar una Persona.", "Alerta", MessageBoxButtons.OK);
        }

        private void lstPersonas_Click(object sender, EventArgs e)
        {
            if(lstPersonas.SelectedIndex != -1)
            { 
                Persona p;
                PersonaDAO consulta = new PersonaDAO();
                p = consulta.LeerPorID(((Persona)lstPersonas.Items[lstPersonas.SelectedIndex]).ID);
                txtApellido.Text = p.Apellido;
                txtNombre.Text = p.Nombre;
            }
                else
                    MessageBox.Show("Debe seleccionar una Persona.", "Alerta", MessageBoxButtons.OK);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstPersonas.SelectedIndex != -1)
            {
                PersonaDAO consulta = new PersonaDAO();
                Persona persona = consulta.LeerPorID(((Persona)lstPersonas.Items[lstPersonas.SelectedIndex]).ID);
                persona.Apellido = txtApellido.Text;
                persona.Nombre = txtNombre.Text;
                consulta.Modificar(persona);
                btnLeer_Click(sender, e);
            }
            else
                MessageBox.Show("Debe seleccionar una Persona.", "Alerta", MessageBoxButtons.OK);

        }


        private void frmEj60_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstPersonas.SelectedIndex != -1)
            {
                PersonaDAO consulta = new PersonaDAO();
                consulta.Borrar(((Persona)lstPersonas.Items[lstPersonas.SelectedIndex]).ID);
                btnLeer_Click(sender, e);
            }
            else
                MessageBox.Show("Debe seleccionar una Persona.", "Alerta", MessageBoxButtons.OK);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PersonaDAO consulta = new PersonaDAO();
            Persona persona = new Persona(0,txtNombre.Text, txtApellido.Text);
            consulta.Guardar(persona);
            btnLeer_Click(sender, e);
        }
    }
}
