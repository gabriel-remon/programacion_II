using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace Test
{
    [TestClass]
    public class GestionImpuestosTest
    {
        [TestMethod]
        public void CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana()
        {
            GestionImpuestos gestionImpuestos = new GestionImpuestos();
            gestionImpuestos.RegistrarImpuestos(new PaqueteFragil("a11", 100, "peep", "pepe", 23));
            gestionImpuestos.RegistrarImpuestos(new PaqueteFragil("a11", 100, "peep", "pepe", 23));
            gestionImpuestos.RegistrarImpuestos(new PaqueteFragil("a11", 100, "peep", "pepe", 23));
            gestionImpuestos.RegistrarImpuestos(new PaquetePesado("a11", 100, "peep", "pepe", 23));
            gestionImpuestos.RegistrarImpuestos(new PaquetePesado("a11", 100, "peep", "pepe", 23));
            gestionImpuestos.RegistrarImpuestos(new PaquetePesado("a11", 100, "peep", "pepe", 23));

            decimal actual = gestionImpuestos.CalcularTotalImpuestosAduana();
            decimal expected = 210;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CalcularImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestosDeAfip()
        {
            GestionImpuestos gestionImpuestos = new GestionImpuestos();
            gestionImpuestos.RegistrarImpuestos(new PaqueteFragil("a11", 100, "peep", "pepe", 23));
            gestionImpuestos.RegistrarImpuestos(new PaqueteFragil("a11", 100, "peep", "pepe", 23));
            gestionImpuestos.RegistrarImpuestos(new PaqueteFragil("a11", 100, "peep", "pepe", 23));
            gestionImpuestos.RegistrarImpuestos(new PaquetePesado("a11", 100, "peep", "pepe", 23));
            gestionImpuestos.RegistrarImpuestos(new PaquetePesado("a11", 100, "peep", "pepe", 23));
            gestionImpuestos.RegistrarImpuestos(new PaquetePesado("a11", 100, "peep", "pepe", 23));

            decimal actual = gestionImpuestos.CalcularTotalImpuestosAfip();
            decimal expected = 75;

            Assert.AreEqual(expected, actual);
        }

    }
}
