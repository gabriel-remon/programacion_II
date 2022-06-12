using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComprobarListaCompetidores_InstanciadaAlCrear_Objeto()
        {
            //arranq
            Competencia competencia = new Competencia(12, 12, Competencia.TipoCompetencia.F1);
            //act

            //assert
            Assert.AreNotEqual(null, competencia.Competidores);

        }
        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void TestNoCargarF1_EnCarrera_MotoCros()
        {
            //arranq
            Competencia competencia = new Competencia(12, 12, Competencia.TipoCompetencia.MotoCross);
            AutoF1 autoF1 = new AutoF1(11, "pepe");
            bool actual;
            //act
            actual = competencia + autoF1;
            
            //assert
        }

        [TestMethod]
        public void TestCargarMotoCros_EnCarrera_MotoCrosknklkl()
        {
            
            Competencia competencia = new Competencia(12, 12, Competencia.TipoCompetencia.MotoCross);
            MotoCross motoCross = new MotoCross(11, "pepe");
            bool actual;
            
            actual = competencia + motoCross;
            bool expected = true;
            
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]

        public void TestComprobarCargaMotoCros_EnCarrera_MotoCrosknklkl()
        {

            Competencia competencia = new Competencia(12, 12, Competencia.TipoCompetencia.MotoCross);
            MotoCross motoCross = new MotoCross(11, "pepe");
            bool actual;

            actual = competencia + motoCross;
            actual = competencia == motoCross;
            bool expected = true;

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestComprobarEliminacionMotoCros_EnCarrera_MotoCrosknklkl()
        {

            Competencia competencia = new Competencia(12, 12, Competencia.TipoCompetencia.MotoCross);
            MotoCross motoCross = new MotoCross(11, "pepe");
            bool actual;

            actual = competencia + motoCross;
            actual = competencia - motoCross;
            actual = competencia != motoCross;
            bool expected = true;

            Assert.AreEqual(expected, actual);

        }
    }
}
