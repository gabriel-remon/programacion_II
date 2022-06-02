using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace TestProject1
{
    [TestClass]
    public class PruebaFizzBuzz
    {
        [TestMethod]
        public void test_DevuelveFizzCuando_EsDivisiblePor3()
        {
            //arrang
            int numeroPrueba = 3; 
            string expected = "Fizz";
            //act
            string actual = numeroPrueba.FizzBuzz();
            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void test_DevuelveBuzzCuando_EsDivisiblePor5()
        {
            //arrang
            int numeroPrueba = 5;
            string expected = "Buzz";
            //act
            string actual = numeroPrueba.FizzBuzz();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(30)]
        [DataRow(300)]
        [DataRow(150)]
        [DataRow(3000)]
        public void test_DevuelveFizzBuzzCuando_EsDivisiblePor3y5(int numeroPrueba)
        {
            //arrang
            //int numeroPrueba = 30;
            string expected = "FizzBuzz";
            //act
            string actual = numeroPrueba.FizzBuzz();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_NoDevuelveFiizBuzzcuando_NoEsDivisiblePor3o5()
        {
            //arrang
            int numeroPrueba = 1;
            string expected = "1";
            //act
            string actual = numeroPrueba.FizzBuzz();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
