using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio1;

namespace tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("1,2",3)]
        [DataRow("1",1)]
        [DataRow("",0)]
        [DataRow("3,3",6)]
        public void TestCalculadoraAdd_SumaDosNumerosSeparados_Porcoma
            (string numeros, int expectic)
        {
            //arrang
            int actual = Calculadora.add(numeros);
            //act
            //int expectic = 3;
            //assert
            Assert.AreEqual(expectic, actual);
        }

        [TestMethod]
        [DataRow("1,1,1,1,1", 5)]
        [DataRow("2,2,2,2,2,2,2,2", 16)]
        [DataRow("3,3,3,3", 12)]
        [DataRow("5,5,5,5,5,5,5,5,5", 45)]
        public void TestCalculadoraAdd_TodosLosNumerosSeparados_Porcoma
            (string numeros, int expectic)
        {
            //arrang
            int actual = Calculadora.add(numeros);
            //act
            //int expectic = 10;
            //assert
            Assert.AreEqual(expectic, actual);
        }
        [TestMethod]
        [DataRow("1\n1,1,1\n1", 5)]
        [DataRow("2\n2,2,2,2\n2,2,2", 16)]
        [DataRow("3\n3,3\n3", 12)]
        [DataRow("5,5,5,5\n5\n5,5,5\n5", 45)]
        public void TestCalculadoraAdd_TodosLosNumerosSeparados_PorcomayContraBarra
           (string numeros, int expectic)
        {
            //arrang
            int actual = Calculadora.add(numeros);
            //act
            //int expectic = 10;
            //assert
            Assert.AreEqual(expectic, actual);
        }
        [TestMethod]
        [DataRow("//;\n1;1;1;1;1", 5)]
        [DataRow("//a\n2a2a2a2a2a2a2a2", 16)]
        [DataRow("//;a\n3;3;3a3", 12)]
        [DataRow("//abc\n5a5b5c5a5b5b5c5c5", 45)]
        public void TestCalculadoraAdd_TodosLosNumerosSeparados_PorCaracterDado
           (string numeros, int expectic)
        {
            //arrang
            int actual = Calculadora.add(numeros);
            //act
            //int expectic = 10;
            //assert
            Assert.AreEqual(expectic, actual);
        }

    }
}
