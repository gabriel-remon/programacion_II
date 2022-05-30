using System;
using Biblioteca;
using System.Collections.Generic;

namespace Ejercicio2_CalculadoraFormas_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura> listaFiguras = new List<Figura>();

            listaFiguras.Add(new Cuadrado(21));
            listaFiguras.Add(new Circulo(11));
            listaFiguras.Add(new Regtangulo(23, 56));

            foreach(Figura unaFigura in listaFiguras)
            {
                
                Console.WriteLine("=========== FIGURA =============");
                Console.WriteLine($"Tipo: {unaFigura.GetType()}");
                Console.WriteLine(unaFigura.Dibujar());
                Console.WriteLine($"Area: {unaFigura.CalcularSuperficue()} ");
                Console.WriteLine($"Perimetro: {unaFigura.CalcularPeimetro()}");
                Console.WriteLine("================================");
            }

            
        }
    }
}
