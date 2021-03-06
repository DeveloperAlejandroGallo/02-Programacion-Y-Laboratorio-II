﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class MGeneral : Medico, IMedico
    {
        public MGeneral(string nombre, string apellido)
            :base(nombre, apellido)
        { }

        public void IniciarAtencionPaciente(Paciente p)
        {
            this.AtenderA = p;
            Thread hiloGeneral = new Thread(Atender);
            hiloGeneral.Start();
        }

        protected override void Atender()
        {
            Thread.Sleep(Medico.tiempoAleatorio.Next(1500, 2200));
            base.FinalizarAtencion();
        }

        public override string ToString()
        {
            return "Médico General - " + base.ToString();
        }
    }
}
