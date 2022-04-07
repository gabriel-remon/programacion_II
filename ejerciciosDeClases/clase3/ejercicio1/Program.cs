using System;
using Biblioteca;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            Cuenta nuevaCuenta = new Cuenta("Gabriel", 0);

            do
            {
                switch (Menu())
                {
                    case 1:
                        Console.WriteLine("Ingrese un monto a depositar");
                        nuevaCuenta.IngresarMonto(decimal.Parse(Console.ReadLine()));
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el monto a retirar");
                        nuevaCuenta.RetiroMonto(decimal.Parse(Console.ReadLine()));
                        break;

                    case 3:
                        Console.Write(nuevaCuenta.mostrar());
                        break;

                    default:
                        Console.WriteLine("Error!!!");
                        break;
                }

                Console.WriteLine("\nDesea Continuar? (S/N)");
            } while ((Console.ReadKey()).KeyChar != 'S');

        }

        public static int Menu()
        {
            int ingreso = 0;

            do
            {
                Console.Clear();
                Console.Write("Cuenta bancaria\n\n" +
                    "1- ingreso dinero\n" +
                    "2- retiro dinero\n" +
                    "3- mostrar cuenta\n");
            } while (!int.TryParse(Console.ReadLine(), out ingreso));
            Console.Clear();
            return ingreso;

        }
    }
}
