using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Producto
    {
        string marca;

        float precio;

        string codigoDeBarra;

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.marca= marca;
            this.codigoDeBarra = codigoDeBarra;
            this.precio = precio;


        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public string GetCodigoDeBarras()
        {
            return this.codigoDeBarra;
        }

        public static string MostrarProducto(Producto p)
        {
            return string.Format("Marca: {0}\nPrecio: {1}\nCodigo de Barras: {2}\n\n",p.GetMarca(),p.GetPrecio(),p.GetCodigoDeBarras());
        }

        public static bool operator ==(Producto a, Producto b)
        {
            return (a.GetMarca() == b.GetMarca() && a.GetCodigoDeBarras() == b.GetCodigoDeBarras());
        }

        public static bool operator ==(Producto p, string str)
        {
            return p.GetMarca() == str;
        }

        public static bool operator !=(Producto a, Producto b)
        {
            return !(a == b);
        }

        public static bool operator !=(Producto p, string str)
        {
            return !(p == str);
        }

        public static explicit operator string(Producto p)
        {
            return p.GetCodigoDeBarras();
        }


    }
}
