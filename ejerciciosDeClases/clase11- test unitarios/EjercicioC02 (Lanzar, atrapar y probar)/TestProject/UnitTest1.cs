using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using EjercicioC01__Lanzar_y_atrapar_;


namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivicionPorCero()
        {
           MiClase.DivicionPorCero();
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMiClase_SinParametros()
        {
            MiClase miClase = new MiClase();
        }
        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void TestMiClase_UnParametroEntrada()
        {
            MiClase miClase = new MiClase(1);
        }

        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void TestOtraClase_SinParametro()
        {
            OtraClase otraClase = new OtraClase();
        }
        
    }
}
