using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej34
{
    public class Camion : VehiculoTerrestreConMarchas
    {
        int pesoCarga;


        public int PesoCarga
        {
            get 
            { 
                return pesoCarga; 
            }
        }
        
        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, int pesoCarga, short cantidadMarchas) 
            : base(cantidadRuedas, cantidadPuertas, color, cantidadMarchas)
        {
            this.pesoCarga = pesoCarga;
        }


    }
}
