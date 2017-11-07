using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej54_Entidades;
using Ej54;

namespace Ej54_Test
{
    [TestClass]
    public class TestCentralita01
    {
        [TestMethod]
        public void aListaDeLlamadasInstanciada()
        {
            Centralita c = new Centralita("La Centralita");
            Assert.IsNotNull(c.Llamadas);
            
        }

        [TestMethod]
        public void bLanzaExcepcionPorDuplicadoLocal()
        {
            Centralita c = new Centralita("La Centralita");
            Local call = new Local("123456789", 10, "987654321", 2.8f);

            try
            {
                c = c + call;
                c = c + call;
            }
            catch (CentralitaException ex)
            {
                Assert.IsInstanceOfType(ex, typeof(CentralitaException));
            }

        }

        [TestMethod]
        public void cLanzaExcepcionPorDuplicadoProvincial()
        {
            Centralita c = new Centralita("La Centralita");
            Provincial call = new Provincial("123456789", Provincial.Franja.Franja_1, 15, "987654321");
            
            try
            {
                c = c + call;
                c = c + call;
            }
            catch (CentralitaException ex)
            {
                Assert.IsInstanceOfType(ex, typeof(CentralitaException));
            }

        }

        [TestMethod]
        public void dComparacionLocalYProvincial()
        {
            Centralita c = new Centralita("La Centralita");
            Provincial p1 = new Provincial("123456789", Provincial.Franja.Franja_1, 10, "987654321");
            Provincial p2 = new Provincial("123456789", Provincial.Franja.Franja_1, 10, "987654321");
            Local l1 = new Local("123456789", 10, "987654321", 2.8f);
            Local l2 = new Local("123456789", 10, "987654321", 2.8f);

            Assert.IsTrue(p1 == p2);
            Assert.IsTrue(l1 == l2);
            Assert.IsFalse(p1 == l1);
            Assert.IsFalse(p2 == l1);
            Assert.IsFalse(p1 == l2);
            Assert.IsFalse(p2 == l2);


        }




    }
}
