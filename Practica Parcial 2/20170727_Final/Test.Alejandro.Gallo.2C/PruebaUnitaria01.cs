using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test.Alejandro.Gallo._2C
{
    [TestClass]
    public class PruebaUnitaria01
    {
        [TestMethod]
        public void tstPacienteConTurno1()
        {
            Paciente paciente = new Paciente("Nombre", "Apellido");
            Assert.IsTrue(paciente.Turno == 1);
        }

        [TestMethod]
        public void tstPacienteConTurno5()
        {
            Paciente paciente = new Paciente("Nombre", "Apellido",5);
            Assert.IsTrue(paciente.Turno == 5);
        }

        [TestMethod]
        public void tstPacienteConTurno6()
        {
            Paciente paciente1 = new Paciente("Nombre", "Apellido", 5);
            Paciente paciente = new Paciente("Nombre", "Apellido");

            Assert.IsTrue(paciente.Turno == 6);
        }
    }
}
