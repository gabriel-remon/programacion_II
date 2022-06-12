using System;
using Biblioteca;

namespace EjercicioI01__torneo_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Partido Futbol");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Partido Basquet");
            //bool operacion;

            //EquipoFutbol equipoF1 = new EquipoFutbol("juenitos", DateTime.Now);

            torneoFutbol = torneoFutbol + new EquipoFutbol("pepe", DateTime.Now);
            torneoFutbol = torneoFutbol + new EquipoFutbol("mongos", DateTime.Now);
            torneoFutbol = torneoFutbol + new EquipoFutbol("juenitos", DateTime.Now);

            torneoBasquet = torneoBasquet + new EquipoBasquet("juenitos", DateTime.Now);
            torneoBasquet = torneoBasquet + new EquipoBasquet("pepe", DateTime.Now);
            torneoBasquet = torneoBasquet + new EquipoBasquet("mongos", DateTime.Now);

            
            Console.WriteLine(torneoBasquet.mostrar());
            Console.WriteLine(torneoFutbol.mostrar());
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);

        }
    }
}
