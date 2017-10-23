using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ej55
{
    public partial class frmArchivos : Form
    {
        string ruta;

        public frmArchivos()
        {
            InitializeComponent();
        }

        private void mnuAbrir_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            { 
                ruta = openFile.FileName;
                StreamReader archivo = new StreamReader(ruta);
                rtbtexto.Text = archivo.ReadToEnd();
                archivo.Close();
            }
        }

        private void mnuGuardar_Click(object sender, EventArgs e)
        {
            if(ruta != null)
            { 
                StreamWriter archivo = new StreamWriter(ruta);
                archivo.Write(rtbtexto.Text);
                archivo.Close();
            }
            else
            {
                mnuGuardarComo_Click(sender, e);
            }

        }

        private void mnuGuardarComo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                ruta = saveFile.FileName;
                StreamWriter archivo = new StreamWriter(ruta);
                archivo.Write(rtbtexto.Text);
                archivo.Close();
            }
        }

        private void rtbtexto_TextChanged(object sender, EventArgs e)
        {
            statLabel.Text = rtbtexto.Text.Length.ToString() + " caracteres";
        }
    }
}
