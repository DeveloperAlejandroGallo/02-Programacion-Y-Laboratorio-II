using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.Threading;

namespace Entidades
{
    public class InfoHilo
    {
        IRespuesta<int> callback;
        Thread hilo;
        int id;
        static Random randomizer;

        static InfoHilo()
        {
            randomizer = new Random();
        }

        public InfoHilo(int id, IRespuesta<int> callback)
        {
            this.id = id;
            this.callback = callback;
            hilo = new Thread(Ejecutar);
            hilo.Start();
        }

        private void Ejecutar()
        {
            Thread.Sleep(randomizer.Next(1000, 5000));
            callback.RespuestaHilo(this.id);
        }





    }
}
