using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseTraingulo;
            double alturaTriangulo;

            Console.WriteLine("Ingrese la base del triangulo");
            baseTraingulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triangulo");
            alturaTriangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("la hipotenusa es: {0}", Hipotenusa(baseTraingulo, alturaTriangulo));

        }

        public static double Hipotenusa(double baseTriangulo, double alturaTriangulo)
        {
            return Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));
        }
    }
}
