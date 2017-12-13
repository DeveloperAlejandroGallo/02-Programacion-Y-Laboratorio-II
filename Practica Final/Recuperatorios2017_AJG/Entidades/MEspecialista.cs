using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class MEspecialista : Medico, IMedico
    {
        Especialidad especialidad;

        public enum Especialidad
        {
            Traumatologo,
            Odontologo
        }

        public MEspecialista(string nombre, string apellido, Especialidad especialidad)
            : base(nombre, apellido)
        {
            this.especialidad = especialidad;
        }

        public override void Atender()
        {
            Thread.Sleep(tiempoAleatorio.Next(5000, 10000));
            base.FinalizarAtencion();
        }

        public void IniciarAtencion(Paciente p)
        {
            Thread hilo = new Thread(Atender);
            hilo.Start();
        }

    }
}
