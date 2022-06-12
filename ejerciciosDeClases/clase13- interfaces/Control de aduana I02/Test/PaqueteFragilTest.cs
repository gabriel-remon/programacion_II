using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;


namespace Test
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAduana()
        {
            PaqueteFragil paqueteFragil = new PaqueteFragil("a21", 100, "argentina", "alemania", 12);

            decimal actual = paqueteFragil.AplicarImpuestos();

            decimal Expected = 135;

            Assert.AreEqual(Expected, actual);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorCientoSobreCostoEnvio()
        {
            PaqueteFragil paqueteFragil = new PaqueteFragil("a21", 100, "argentina", "alemania", 12);

            decimal actual = paqueteFragil.Impuestos;

            decimal Expected = 35;

            Assert.AreEqual(Expected, actual);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            PaqueteFragil paqueteFragil = new PaqueteFragil("a21",21,"argentina","alemania",12);

            bool actual = paqueteFragil.TienePrioridad; 

            bool Expected = true;

            Assert.AreEqual(Expected, actual);

        }
    }
}
