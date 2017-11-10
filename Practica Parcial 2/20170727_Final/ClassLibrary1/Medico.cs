using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Medico : Persona
    {
        public delegate void FinAtencionPaciente(Paciente p, Medico m);

        public event FinAtencionPaciente AtencionFinalizada;

        Paciente pacienteActual;
        static protected Random tiempoAleatorio;

        public Paciente AtenderA
        {
            set
            {
                this.pacienteActual = value;
            }
        }

        public virtual string EstaAtendiendoA
        {
            get
            {
                return this.pacienteActual.ToString();
            }
        }

        static Medico()
        {
            tiempoAleatorio = new Random();
        }

        public Medico(string nombre, string apellido)
            :base(nombre,apellido)
        {}

        protected abstract void Atender();

        public void FinalizarAtencion()
        {
            this.AtencionFinalizada(this.pacienteActual, this);
            this.pacienteActual = null;
        }

        //public override string ToString()
        //{
        //    return base.apellido + ", " + base.nombre;
        //}
    }
}
