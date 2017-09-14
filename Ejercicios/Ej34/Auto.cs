using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej34
{
    public class Auto : VehiculoTerrestreConMarchas
    {
        short cantidadPasajeros;

        public short CantidadPasajeros
        {
            get
            {
                return cantidadPasajeros;
            }
        }

        public Auto(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadPasajeros, short cantidadMarchas)
            : base(cantidadRuedas, cantidadPuertas, color, cantidadMarchas)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }

    }
}
