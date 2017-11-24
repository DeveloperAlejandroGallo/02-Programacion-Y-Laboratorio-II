using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesHechas;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class TestCorreo
    {
        [TestMethod]
        public void ListaDePaquetesInstanciada()
        {
            Correo correo = new Correo();
            Assert.IsInstanceOfType(correo.Paquetes, typeof(List<Paquete>));
        }

        [TestMethod]
        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void NoCargarDosTrackingIDIguales()
        {
            string 
                track = "123456478",
                dir = "Rivadavia 1";
            Correo correo = new Correo();
            Paquete paquete = new Paquete(dir,track);
            correo = correo + paquete;
            Paquete paquete2 = new Paquete(dir, track);
            correo = correo + paquete2;
        }



    }
}
