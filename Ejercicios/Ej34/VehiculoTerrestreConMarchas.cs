using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej34
{
    public class VehiculoTerrestreConMarchas : VehiculoTerrestre 
    {
        short cantidadMarchas;

        public short CantidadMarchas
        {
            get
            {
                return cantidadMarchas;
            }
        }
        public VehiculoTerrestreConMarchas(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas) 
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
        }

    }
}
