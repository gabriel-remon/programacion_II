using System;
namespace ejercicio3

{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngreso = 0;
            bool flagPrimo = true;
            int contador = 0;
            ConsoleKeyInfo opcion  ;

            do
            {

                Console.WriteLine("Ingrese un numero");
                if (int.TryParse(Console.ReadLine(), out numeroIngreso))
                {
                    Console.Clear();
                    if (numeroIngreso > 2)
                    {
                        for (int i = numeroIngreso; i > 0; i--)
                        {
                            contador = 0;
                            for (int b = i - 1; b > 0; b--)
                            {

                                if ((i % b) == 0)
                                {
                                    contador++;
                                }
                                if (contador == 2)
                                {
                                    break;
                                }
                            }

                            if (contador == 1)
                            {
                                if (flagPrimo)
                                {
                                    Console.WriteLine("Lista de numeros primos anteriores al numero {0}:", numeroIngreso);
                                    flagPrimo = false;
                                }
                                Console.WriteLine("Numero {0}", i);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay numeros primos antes que el numero {0}", numeroIngreso);

                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Error ingrese solamente numeros");
                }
                do
                {
                    Console.WriteLine("Desea ingresar otro numero? (Y/N)");
                    opcion = Console.ReadKey();
                    Console.Clear();

                } while ((opcion.KeyChar != 'N') && (opcion.KeyChar != 'n') && (opcion.KeyChar != 'Y') && (opcion.KeyChar != 'y'));

            } while ((opcion.KeyChar != 'N') && (opcion.KeyChar != 'n'));

        }
    }
}
