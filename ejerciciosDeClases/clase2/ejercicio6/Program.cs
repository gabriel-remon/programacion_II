using System;

namespace ejercicio6
{
    class Program
    {

        static void Main(string[] args)
        {
            double area = 0;
            double baseTriangulo = 0;
            double alturaTriangulo = 0;

            switch (Menu())
            {
                case 1:
                    Console.WriteLine("Ingrese la longitud del lado");
                    area = CalculadoraDeArea.CalcularAreaCuadrado(double.Parse(Console.ReadLine()));
                    break;

                case 2:
                    Console.WriteLine("Ingrese la longitud de la base");
                    baseTriangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura");
                    alturaTriangulo = double.Parse(Console.ReadLine());

                    area = CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);
                    break;

                case 3:
                    Console.WriteLine("ingrese el radio del circulo");
                    area = CalculadoraDeArea.CalcularAreaCirculo(double.Parse(Console.ReadLine()));
                    break;
            }

            Console.WriteLine("El area es: {0}", area);

        }

        static int Menu()
        {
            int retorno = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("@ seleccione la opcion" +
                    "\n1 Calcular area cuadrado" +
                    "\n2 calular area triangulo" +
                    "\n3 calcular area circulo");
            } while (!(int.TryParse(Console.ReadLine(), out retorno)));

            Console.Clear();
            return retorno;
        }


    }
}
