using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Estante
    {
        int capacidadMax;
        int ubicacion;
        Producto[] productos;


        public Estante(int capacidadMax, int ubicacion) : this(capacidadMax)
        {
            this.capacidadMax = capacidadMax;
            this.ubicacion = ubicacion;
        }
        private Estante(int size)
        {
            productos = new Producto[size];
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }
        
        public int CuantosProductosLlenos()
        {
            int cant = 0;

            foreach(var prod in this.productos)
            {
                if (!object.ReferenceEquals(prod, null))
                    cant++;
            }

            return cant;
        }

        public static string MostrarEstante(Estante e)
        {
            string ret = string.Format("ESTANTE\nCapacidad Max: {0}\nUbicacion: {1}\n\nPRODUCTOS:\n",e.capacidadMax,e.ubicacion);
            foreach (var prod in e.productos)
            {
                ret += Producto.MostrarProducto(prod);
            }

            return ret;
        }
        /// <summary>
        /// Igualdad, retornará true, si es que el producto ya se encuentra en el estante, false, caso contrario.
        /// </summary>
        /// <param name="estante"></param>
        /// <param name="prod"></param>
        /// <returns></returns>
        public static bool operator ==(Estante estante, Producto prod)
        {
            bool ret = false;

            foreach (var p in estante.GetProductos())
            {
                if (!object.ReferenceEquals(p, null))
                {
                    if (p == prod)
                    {
                        ret = true;
                        break;
                    }
                }
            }

            return ret;
        }
        public static bool operator !=(Estante estante, Producto prod)
        {
            return !(estante == prod);
        }
        /// <summary>
        /// Adición, retornará true y agregará el producto si el estante posee capacidad de almacenar al menos un producto más y 
        /// dicho producto no se encuentra en él; false, caso contrario. Reutilizar código.
        /// </summary>
        /// <param name="estante"></param>
        /// <param name="prd"></param>
        /// <returns></returns>
        public static bool operator +(Estante estante, Producto prd)
        {
            bool ret = false;
            if(!(estante == prd) && estante.capacidadMax > estante.CuantosProductosLlenos())
            {
                estante.productos[estante.PosicionVacia()] = prd;
                ret = true;
            }
            
            return ret;
        }

        public static Estante operator -(Estante estante, Producto prd)
        {

            if(estante == prd)
                estante.productos[estante.GetPosicionProducto(prd)] = null;

            return estante;
        }

        public int GetPosicionProducto(Producto prod)
        {
            int pos = 0;

            foreach (var p in this.GetProductos())
            {
                if (p == prod)
                    break;
                
                pos++;
            }

            return pos;
        }

        public int PosicionVacia()
        {
            int i=0;
            foreach(var p in this.productos)
            {
                if(object.ReferenceEquals(p,null))
                {
                    break;
                }
                i++;
            }

            return i;
        }

    }
}
