using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrueba01
{
    public partial class Form1 : Form
    {
        public Form[,] lista;
        public int cant = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lista = new Form[cant,1];
            lista.Initialize();
            lista[0,0] = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "Ale";
            string b = "Gallo";
            string sp = " ";
            b = String.Concat(a,b,sp);
            b.CompareTo(a);

            if (MessageBox.Show(b, "Concat", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification) == DialogResult.OK)
                lista[0, 0].Close();
            else
                lista[0, 0].Activate();
        }
    }
}
