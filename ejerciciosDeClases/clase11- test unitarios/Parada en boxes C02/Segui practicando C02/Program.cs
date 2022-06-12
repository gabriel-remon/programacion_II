using System;
using Biblioteca;

namespace Segui_practicando_C02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Competencia competencia = new Competencia(12, 12, Competencia.TipoCompetencia.MotoCross);
            MotoCross motoCross = new MotoCross(11, "pepe");
            bool actual;

            actual = competencia + motoCross;
            bool expected = true;

            //Assert.AreEqual(expected, actual);

            Console.WriteLine(actual);
        }
    }
}
