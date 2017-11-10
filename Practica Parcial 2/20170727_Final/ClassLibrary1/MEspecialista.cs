using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class MEspecialista:Medico,IMedico
    {
        public enum Especialidad
        {
            Traumatologo,
            Odontologo
        }

        Especialidad especialidad;

        public MEspecialista(string nombre, string apellido, Especialidad e)
            :base(nombre, apellido)
        {
            this.especialidad = e;
        }

        public void IniciarAtencionPaciente(Paciente p)
        {
            this.AtenderA = p;
            Thread hiloEspecialidad = new Thread(Atender);
            hiloEspecialidad.Start();
        }

        protected override void Atender()
        {
            Thread.Sleep(Medico.tiempoAleatorio.Next(5000, 10000));
            base.FinalizarAtencion();
        }

        public override string ToString()
        {
            return "Médico Especialista - " + base.ToString();
        }

    }
}
