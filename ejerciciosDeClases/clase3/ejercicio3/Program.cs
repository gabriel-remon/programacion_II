using System;
using Biblioteca;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante alumno1 = new Estudiante("Juan","Domingues","324") ;
            Estudiante alumno2 = new Estudiante("Micaela", "Suarez", "1122");
            Estudiante alumno3 = new Estudiante("Simon", "Perez", "10033");

            alumno1.SetNotaPrimerParcial(2);
            alumno2.SetNotaPrimerParcial(8);
            alumno3.SetNotaPrimerParcial(9);

            alumno1.SetNotaSegundoParcial(3);
            alumno2.SetNotaSegundoParcial(6);
            alumno3.SetNotaSegundoParcial(2);

            Console.WriteLine(alumno1.mostrar());
            Console.WriteLine(alumno2.mostrar());
            Console.WriteLine(alumno3.mostrar());
        }
    }
}
