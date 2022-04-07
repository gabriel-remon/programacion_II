using System;
using biblioteca;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo salir;
            bool flagIngresoNumero = false;
            int suma = 0;
            int numeroIngreso = 0;
            do
            {
                Console.Clear();
                do
                {
                    flagIngresoNumero = false;
                    Console.WriteLine("Ingrese un numero entero");
                    flagIngresoNumero = int.TryParse(Console.ReadLine(), out numeroIngreso);

                    Console.Clear();
                    if(!flagIngresoNumero)
                    {
                        Console.WriteLine("Error!!");
                    }
                } while (!flagIngresoNumero);

                suma = suma + numeroIngreso;

                Console.WriteLine("La suma total es: {0} \n\n", suma);
                Console.WriteLine("Desea constinuar? (S/N)");
                salir = Console.ReadKey();
                
            } while (validaror.ValidarRespuesta(salir));
        }
    }
}
