using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {

            int alturIngreso = 0;

            bool ingreso;
            ConsoleKeyInfo salir;


            do
            {
                alturIngreso = 0;
                do
                {
                    Console.WriteLine("Ingrese la altura del triangulo");
                    ingreso = int.TryParse(Console.ReadLine(), out alturIngreso);
                    Console.Clear();
                } while (!ingreso || alturIngreso < 0);

                for (int i = 0; i < alturIngreso; i++)
                {
                    for (int b = i + 1; b > 0; b--)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }

                do
                {
                    Console.WriteLine("Desea salir? (Y/N)");
                    salir = Console.ReadKey();
                    Console.Clear();
                } while (salir.KeyChar != 'N' && salir.KeyChar != 'Y');

            } while (salir.KeyChar != 'Y');
        }
    }
}
