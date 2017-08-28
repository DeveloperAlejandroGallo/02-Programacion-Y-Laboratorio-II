using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Punto
    {
        int x;

        int y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        public int getX()
        {
            return this.x;
        }
        public int getY()
        {
            return this.y;
        }


    }
}
