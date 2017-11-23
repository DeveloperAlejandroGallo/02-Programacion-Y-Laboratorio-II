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

namespace PruebaPre2doParcial
{
    public partial class frmPpal : Form
    {
        public frmPpal()
        {
            InitializeComponent();
        }

        private void frmPpal_Load(object sender, EventArgs e)
        {
            List<string> datos = new List<string>();
            TXT.LeerTxt(out datos);

            foreach(string line in datos)
            {
                lbxFinalizado.Items.Add(line);
            }
            

        }
    }
}
