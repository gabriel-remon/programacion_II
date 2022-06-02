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
            bool operacion;

            EquipoFutbol equipoF1 = new EquipoFutbol("juenitos", DateTime.Now);

            operacion = torneoFutbol + equipoF1;
          
            operacion = torneoFutbol + new EquipoFutbol("pepe", DateTime.Now);
            operacion = torneoFutbol + new EquipoFutbol("mongos", DateTime.Now);

            operacion = torneoBasquet + new EquipoBasquet("juenitos", DateTime.Now);
            operacion = torneoBasquet + new EquipoBasquet("pepe", DateTime.Now);
            operacion = torneoBasquet + new EquipoBasquet("mongos", DateTime.Now);

            Console.WriteLine(torneoBasquet.mostrar());
            Console.WriteLine(torneoFutbol.mostrar());

        }
    }
}
