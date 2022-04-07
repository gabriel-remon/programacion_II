using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngreso;


            Console.WriteLine("Ingrese un numero");
 REINTENTO:
            numeroIngreso = int.Parse(Console.ReadLine());
            if(numeroIngreso>0)
            {
                Console.WriteLine(" el cuadrado del numero es {0}. El cubo del numero es: {1}",Math.Pow(numeroIngreso, 2),Math.Pow(numeroIngreso, 3));
            }
            else
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                goto REINTENTO;
            }
        }
    }
}
