using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        public float area;
        public float lado;
        public float largoBase;
        public float perimetro;
        public Punto vertice1;
        public Punto vertice2;
        public Punto vertice3;
        public Punto vertice4;

        public Rectangulo(Punto v1, Punto v3)
        {
            this.vertice1 = v1;
            this.vertice3 = v3;

            this.largoBase = v1.getX() - v3.getX();
            if (this.largoBase < 0)
                this.largoBase *= -1;

            this.lado = v1.getY() - v3.getY();
            if (this.lado < 0)
                this.lado *= -1;

            this.perimetro = 2 * this.lado + 2 * this.largoBase;

            this.area = this.largoBase * this.lado;

        }


    }
}
