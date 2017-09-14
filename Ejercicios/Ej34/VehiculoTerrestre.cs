using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej34
{
    public class VehiculoTerrestre
    {
        public enum Colores
        {
            Rojo, 
            Blanco, 
            Azul, 
            Gris, 
            Negro
        }

        short cantidadRuedas;
        short cantidadPuertas;
        Colores color;

        #region Propiedades

        public short CantidadRuedas
        {
            get
            {
                return cantidadRuedas;
            }
        }

        public short CantidadPuertas
        {
            get
            {
                return cantidadPuertas;
            }
        }

        public Colores Color
        {
            get
            {
                return color;
            }
        }

        #endregion


        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color )
        {
            this.cantidadPuertas = cantidadPuertas;
            this.cantidadRuedas = cantidadRuedas;
            this.color = color;
        }
    }
}
