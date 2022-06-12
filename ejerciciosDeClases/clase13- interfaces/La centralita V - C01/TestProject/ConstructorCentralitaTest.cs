using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestCentralita
{
    [TestClass]
    public class ConstructorCentralitaTest
    {
        [TestMethod]
        [DataRow(null)]
        public void Constructor_SinParametros
            (List<Llamada> expected)
        {
            //arrang
            //List<Llamada> expected = null;
            //act
            Centralita actual = new Centralita();
            //assert
            Assert.AreNotEqual(expected, actual.Llamadas);
        }

        [TestMethod]
        [DataRow(null,"PEPE")]
        public void Constructor_ConParametros
            (List<Llamada> expected,string nombreCentral)
        {
            //arrang
            //List<Llamada> expected = null;
            //act
            Centralita actual = new Centralita(nombreCentral);
            //assert
            Assert.AreNotEqual(expected, actual.Llamadas);

        }
    }
}
namespace TestExcepcionesCentralita
{
    [TestClass]
    public class ConstructorCentralitaTest
    {
        [TestMethod]
        //  [DataRow(null)]
        [ExpectedException(typeof(CentralitaExcepcion))]
        public void TestExcepcionCentralita_NoCargarLlamadaLocalConNumerosExistentes_CostoyDuracionDistintos()
        {
            //arrang
            Centralita centralita = new Centralita();
            Local local1 = new Local("11111111", 50, "22222222", 20);
            Local local2 = new Local("11111111", 11, "22222222", 33);
            //act
            centralita = centralita + local1;
            //assert
            //Assert.AreEqual(centralita, centralita + local1);
            centralita = centralita + local2;
        }

        [TestMethod]
        //  [DataRow(null)]
        [ExpectedException(typeof(CentralitaExcepcion))]
        public void TestExcepcionCentralita_NoCargarLlamadaProvincialConNumerosExistentes_CostoyDuracionDistintos()
        {
            //arrang
            Centralita centralita = new Centralita();
            Provincial provincial1 = new Provincial("11111111",Franja.Franja_1,12,"22222222");
            Provincial provincial2 = new Provincial("11111111", Franja.Franja_2, 33, "22222222");
            //act
            centralita = centralita + provincial1;
            //assert
            //Assert.AreEqual(centralita, centralita + local1);
            centralita = centralita + provincial2;
        }


    }
}
namespace TestLlamadas
{
    [TestClass]
    public class ConstructorCentralitaTest
    {
        [TestMethod]
        //  [DataRow(null)]

        public void TestIgualacionDeLLamadas_SoloIgualMismoNumeroYTipo()
        {
            //arrang

            Local local1 = new Local("11111111", 50, "22222222", 20);
            Local local2 = new Local("11111111", 11, "22222222", 33);
            Provincial provincial1 = new Provincial("11111111", Franja.Franja_1, 12, "22222222");
            Provincial provincial2 = new Provincial("11111111", Franja.Franja_2, 33, "22222222");
            //act

            //assert
            Assert.AreEqual(local1==local2, true);
            Assert.AreEqual(local1==provincial1, false);
            Assert.AreEqual(local1==provincial2, false);
            Assert.AreEqual(local2 == provincial1, false);
            Assert.AreEqual(local2 == provincial2, false);
            Assert.AreEqual(provincial1 == provincial2, true);
            Assert.AreEqual(provincial1 == local1, false);
            Assert.AreEqual(provincial1 == local2, false);
            Assert.AreEqual(provincial2 == local1, false);
            Assert.AreEqual(provincial2 == local2, false);
        }
       
    }
}
