using System;
using Biblioteca;

namespace Contabilidad_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            contabilidad = contabilidad + new Factura(213);
            contabilidad = contabilidad + new Factura(32);
            contabilidad = contabilidad + new Factura(55);
            contabilidad = contabilidad + new Recibo(5);
            contabilidad = contabilidad + new Recibo(8);
            contabilidad = contabilidad + new Recibo();

            Console.WriteLine(contabilidad.mostrar());

        }
    }
}
