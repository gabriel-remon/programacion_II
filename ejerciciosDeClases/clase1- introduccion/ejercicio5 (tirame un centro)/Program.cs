using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngreso = 0;
            //int centroNumerico = 0;
            int grupo1 = 0;
            int grupo2 = 0;
            int centroEncontrado = 0;
            bool ingreso = false;
            ConsoleKeyInfo salir;

            do
            {
                do
                {
                    Console.WriteLine("Ingrese un numero positivo");
                    ingreso = int.TryParse(Console.ReadLine(), out numeroIngreso);
                    Console.Clear();

                } while (!false && numeroIngreso < 1);
                centroEncontrado = 0;

                for (float i = 3; i <= numeroIngreso; i++)
                {
                    grupo1 = (int)(i * (i + 1)) / 2;

                    for (float b = i + 2; b <= numeroIngreso; b++)
                    {
                        grupo2 = (int)(((b * (b + 1)) / 2) - ((i + 1) * ((i + 2) / 2)));

                        if (grupo1 == grupo2)
                        {
                            centroEncontrado++;
                            Console.WriteLine("El {5}ºcentro es {0}, entre ({1},{2}) y ({3},{4}) ", i + 1, 1, i, i + 2, b, centroEncontrado);
                            break;
                        }
                        if (grupo2 > grupo1)
                        {
                            break;
                        }
                    }
                }

                if (centroEncontrado == 0)
                {
                    Console.WriteLine("No hay un centro entre 1 y {0}", numeroIngreso);
                }

                do
                {
                    Console.WriteLine("Desea salir?(Y/N)");
                    salir = Console.ReadKey();
                    Console.Clear();

                } while (salir.KeyChar != 'N' && salir.KeyChar != 'Y');

            } while (salir.KeyChar == 'N');

        }

    }
}

