using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ19_Boligrafo
{
    class Boligrafo
    {
        ConsoleColor color;

        int tinta;

        public Boligrafo(ConsoleColor color, int tinta)
        {
            this.color = color;
            this.tinta = 0;
            if (tinta <= 100)
                this.tinta = tinta;
        }

        public bool Pintar(int gasto);

        public void Recargar();

        public ConsoleColor getColor()
        {
            return this.color;
        }

        public int getTinta()
        {
            return this.tinta;
        }



    }
}
