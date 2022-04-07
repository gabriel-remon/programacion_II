using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int alturaIngreso = 0;
            int alturaAux = 0;

            bool ingreso;
            ConsoleKeyInfo salir;

            do
            {
                do
                {
                    Console.WriteLine("Ingrese la altura del trigangulo");
                    ingreso = int.TryParse(Console.ReadLine(), out alturaIngreso);
                } while (!ingreso || alturaIngreso < 0);

                alturaAux = alturaIngreso;
                for(int i=alturaIngreso ; i>0 ; i--)
                {
                    for(int a=i-1; a>0; a--)
                    {
                        Console.Write(" ");
                    }
                    for(int b =(alturaAux-(i-1)); b > 0 ; b-- )
                    {
                        Console.Write("*");
                    }
                    alturaAux++;
                    Console.Write("\n");

                }

                do
                {
                    Console.WriteLine("Desea salir?(Y/N)");
                    salir = Console.ReadKey();
                    Console.Clear();
                } while (salir.KeyChar != 'N' && salir.KeyChar != 'Y');


            } while (salir.KeyChar != 'Y');
        }
    }
}
