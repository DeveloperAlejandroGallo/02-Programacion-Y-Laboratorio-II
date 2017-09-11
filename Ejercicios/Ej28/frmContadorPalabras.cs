using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej28
{
    public partial class frmContadorPalabras : Form
    {
        public frmContadorPalabras()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> diccPalabras = new Dictionary<string, int>();
            string palabra="";

            foreach(var letra in txtPalabras.Text)
            {
                if(Char.IsLetter(letra))
                {
                    palabra += letra;
                }
                else
                {
                    if(palabra.Length > 0)
                    {
                        if(diccPalabras.ContainsKey(palabra))
                        {
                            diccPalabras[palabra]++;
                        }
                        else
                        {
                            diccPalabras.Add(palabra, 1);
                        }
                        
                    }

                    palabra = "";
                }
                    
            }

            if (palabra.Length > 0)
            {
                if (diccPalabras.ContainsKey(palabra))
                {
                    diccPalabras[palabra]++;
                }
                else
                {
                    diccPalabras.Add(palabra, 1);
                }

            }

            int i = 1;
            string mensaje = "";
            foreach(var dic in diccPalabras.OrderByDescending(x => x.Value))
            {
                if (i <= 3)
                {
                    mensaje += dic.Key + ": " + dic.Value.ToString() + "\n";
                }
                else
                    break;
                i++;
            }

            MessageBox.Show(mensaje,"PALABRAS CON MAS APARICIONES");

        }
    }
}
