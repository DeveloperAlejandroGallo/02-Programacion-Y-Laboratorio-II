using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ej66
{
    public class Temporizador
    {
        public delegate void encargadoTiempo(object obj, EventArgs e);

        public event encargadoTiempo EventoTiempo;

        Thread hilo;
        int intervalo;

        public Temporizador()
        {
            this.Intervalo = 1000;
            this.Activo = true;

        }


        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }

        public bool Activo
        {
            get
            {
                if(!object.ReferenceEquals(hilo,null) && hilo.IsAlive)
                {
                    return true;
                }
                return false;
            }
            set
            {
                if (value && !this.Activo)
                {
                    hilo = new Thread(Corriendo);
                    hilo.Start();
                }
                else
                    hilo.Abort();
            }
        }


        public void Corriendo()
        {
            while (true)
            {
                Thread.Sleep(Intervalo);
                this.EventoTiempo(this, new EventArgs());
            }

        }

        public void KillThread()
        {
            if (this.Activo)
                this.hilo.Abort();
        }

    }
}
