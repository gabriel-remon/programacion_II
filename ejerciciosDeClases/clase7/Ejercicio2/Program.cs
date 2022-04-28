using System;
using Biblioteca;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro nuevoLibro = new Libro();

            nuevoLibro[0] = "pepe juan carlos";
            nuevoLibro[1] = "mono con bananas";
            nuevoLibro[2] = "esto no es coca papi";
            nuevoLibro[3] = "aca en la pileee";

            for (int i=0; i<=3; i++)
            {
                Console.WriteLine(nuevoLibro[i]);
            }

            nuevoLibro[0] = "---------------";
            nuevoLibro[1] = "mi pija peluda";
            nuevoLibro[2] = "0";
            nuevoLibro[3] = ">>>>>>>>>";
            nuevoLibro[4] = "0";

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(nuevoLibro[i]);
            }


        }
    }
}
