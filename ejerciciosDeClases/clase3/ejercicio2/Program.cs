using System;
using Biblioteca;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            persona persona1 = new persona();
            persona persona2 = new persona();
            persona persona3 = new persona();

            persona1.SetNombre("juan");
            persona1.SetFecha(2008,2,22) ;
            persona1.SetDni(23333222);

            persona2.SetNombre("beatriz");
            persona2.SetFecha(1800,3,3);
            persona2.SetDni(900100);

            persona3.SetNombre("pepe");
            persona3.SetFecha(2005,3,1);
            persona3.SetDni(32323232);

            for (int i=0; i<1; i++)
            {
                Console.WriteLine(persona1.mostrar());
                Console.WriteLine(persona1.EsMayorDeEdad());

                Console.WriteLine(persona2.mostrar());
                Console.WriteLine(persona2.EsMayorDeEdad());

                Console.WriteLine(persona3.mostrar());
                Console.WriteLine(persona3.EsMayorDeEdad());
                
            }
        }
    }
}
