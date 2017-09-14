using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej34
{
    public class Moto : VehiculoTerrestre
    {
        short cilindrada;
        public short Cilindrada
        {
            get
            {
                return cilindrada;
            }
        }
        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cilindrada = cilindrada;
        }

    }
}
