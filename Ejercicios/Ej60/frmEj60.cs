using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej60
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
            Persona p;
            PersonaDAO consulta = new PersonaDAO();
            p = consulta.LeerPorID(((Persona)lstPersonas.Items[lstPersonas.SelectedIndex]).ID);
            txtApellido.Text = p.Apellido;
            txtNombre.Text = p.Nombre;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            PersonaDAO consulta = new PersonaDAO();
            Persona persona = new Persona(txtNombre.Text, txtApellido.Text);
            consulta.Modificar(lstPersonas.SelectedIndex + 1, persona);
            btnLeer_Click(sender, e);

        }

        private void lstPersonas_Click(object sender, EventArgs e)
        {
            Persona p;
            PersonaDAO consulta = new PersonaDAO();
            p = consulta.LeerPorID(lstPersonas.SelectedIndex + 1);
            txtApellido.Text = p.Apellido;
            txtNombre.Text = p.Nombre;
        }

        private void frmEj60_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PersonaDAO consulta = new PersonaDAO();
            consulta.Borrar(lstPersonas.SelectedIndex + 1);
            btnLeer_Click(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PersonaDAO consulta = new PersonaDAO();
            Persona persona = new Persona(txtNombre.Text, txtApellido.Text);
            consulta.Guardar(persona);
            btnLeer_Click(sender, e);
        }
    }
}
