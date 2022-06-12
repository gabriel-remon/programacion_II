using System;
using Biblioteca;

namespace Cartuchera_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);

            EscrituraWrapper eLapiz = miLapiz.Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);

            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);

            Console.ReadKey();


            CartucheraMultiuso cartucheraMultiuso = new CartucheraMultiuso();
            CartucheraSimple cartucheraSimple = new CartucheraSimple();

            cartucheraMultiuso.acciones.Add(new Lapiz(20));
            cartucheraMultiuso.acciones.Add(new Lapiz(1));
            cartucheraMultiuso.acciones.Add(new Lapiz(42));
            cartucheraMultiuso.acciones.Add(new Boligrafo(12,ConsoleColor.Green));
            cartucheraMultiuso.acciones.Add(new Boligrafo(10,ConsoleColor.Green));
            cartucheraMultiuso.acciones.Add(new Boligrafo(32,ConsoleColor.Green));
            bool aux;
            int i = 0;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
                Console.WriteLine("Cartuchera Multiusos");
            do
            {
                aux = cartucheraMultiuso.RecorrerElementos();
                i++;
                Console.WriteLine(aux);
            } while (aux);
                Console.WriteLine(i);
            i = 0;

            cartucheraSimple.lapices.Add(new Lapiz(20));
            cartucheraSimple.lapices.Add(new Lapiz(2323));
            cartucheraSimple.lapices.Add(new Lapiz(42));
            cartucheraSimple.boligrafos.Add(new Boligrafo(1, ConsoleColor.Green));
            cartucheraSimple.boligrafos.Add(new Boligrafo(10, ConsoleColor.Green));
            cartucheraSimple.boligrafos.Add(new Boligrafo(32, ConsoleColor.Green));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
                Console.WriteLine("Cartuchera simple");
            do
            {
                aux = cartucheraSimple.RecorrerElementos();
                i++;
                Console.WriteLine(aux);
            } while (aux);
                Console.WriteLine(i);

        }
    }
}
