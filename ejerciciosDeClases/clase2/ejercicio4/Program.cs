using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float primerOperador = 0;
            float segunOperador = 0;
            float resultado = 0;
            ConsoleKeyInfo operadorIngreso;

            Console.WriteLine("Ingrese el primer operador");
            primerOperador = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo operador");
            segunOperador = float.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el operador");
            operadorIngreso = Console.ReadKey();

            Console.Clear();

            resultado = Calculadora.Calcular(operadorIngreso, primerOperador, segunOperador);

            Console.WriteLine("El resultado es {0}", resultado);
        }
    }
}
