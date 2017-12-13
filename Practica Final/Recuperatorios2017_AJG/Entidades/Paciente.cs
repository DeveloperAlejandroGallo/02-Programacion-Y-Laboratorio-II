using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        #region Atributos
        int turno;
        static int ultimoTurnoDado;

        #endregion
        #region Constructores
        static Paciente()
        {
            ultimoTurnoDado = 0;
        }

        public Paciente(string nombre, string apellido)
            : base(nombre, apellido)
        {
            this.turno = ++ultimoTurnoDado;

        }

        public Paciente(string nombre, string apellido, int turno)
            : this(nombre, apellido)
        {
            this.turno = turno;
            ultimoTurnoDado = turno;
        }
        #endregion

        #region Metodos

        public override string ToString()
        {
            return string.Format("Turno N° {0}: {2}, {1}", this.turno, this.nombre, this.apellido);
        }

        #endregion
    }
}
