using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        int turno;
        static int ultimoTurnoDado;

        static Paciente()
        {
            ultimoTurnoDado = 0;
        }

        public Paciente(string nombre, string apellido)
            :base(nombre,apellido)
        {
            this.turno = ++ultimoTurnoDado ;
        }

        public Paciente(string nombre, string apellido, int turno)
            :base(nombre, apellido)
        {
            this.turno = turno;
            Paciente.ultimoTurnoDado = turno;
        }

        public int Turno
        {
            get
            {
                return this.turno;
            }
        }


        public override string ToString()
        {
            return string.Format("Turno Nº{0}: {1}", this.turno, base.ToString()); 
        }

    }
}
