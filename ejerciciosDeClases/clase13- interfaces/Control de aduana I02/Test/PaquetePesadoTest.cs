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
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana()
        {
            PaquetePesado paquetePesado = new PaquetePesado("a21", 100, "argentina", "alemania", 12);

            decimal actual = paquetePesado.AplicarImpuestos();

            decimal Expected = 160;

            Assert.AreEqual(Expected, actual);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorCientoSobreCostoEnvio_CuandoEsImplementacionExplicitalAfip()
        {
            PaquetePesado paquetePesado = new PaquetePesado("a21", 100, "argentina", "alemania", 12);

            decimal actual = ((IAfip)paquetePesado).Impuestos;

            decimal Expected = 25;

            Assert.AreEqual(Expected, actual);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorCientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
            PaquetePesado paquetePesado = new PaquetePesado("a21", 100, "argentina", "alemania", 12);

            decimal actual = paquetePesado.Impuestos;

            decimal Expected = 35;

            Assert.AreEqual(Expected, actual);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            PaquetePesado paquetePesado = new PaquetePesado("a21", 21, "argentina", "alemania", 12);

            bool actual = paquetePesado.TienePrioridad;

            bool Expected = false;

            Assert.AreEqual(Expected, actual);

        }
    }

    }

