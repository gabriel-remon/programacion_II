using System;
using Biblioteca;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = 45;
            long b = 64;

            string c = "hola ";
            string d = "mundo";

            Sumador sumador = new Sumador(12);

            Console.WriteLine($"cantidad sumas {(int)sumador}");
            Console.WriteLine($"la sumas de a y b es {sumador.Sumar(a, b)} ");
            Console.WriteLine($"la cantidad de sumas es {(int)sumador}");
            Console.WriteLine($"Concatenar sting {sumador.Sumar(c, d)}");
            Console.WriteLine($"El sumador de sumas es {(int) sumador}");
            Console.ReadKey();
        }
    }
}
