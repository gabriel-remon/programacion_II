using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int anioIngresoInicio = 0;
            int anioIngresoFinal = 0;
            int anioAux = 0;
            int contadorViciesto = 0;

            bool validarInicio;
            bool validarFinal;
            ConsoleKeyInfo salir;

            Console.WriteLine("Anios biviestos \n\n");

            do
            {
                do
                {
                    Console.WriteLine("Ingrese el anio de inicio");
                    validarInicio = int.TryParse(Console.ReadLine(),out anioIngresoInicio);
                    Console.Clear();
                } while (!validarInicio);

                do
                {
                    Console.WriteLine("Ingrese el anio final");
                    validarFinal = int.TryParse(Console.ReadLine(), out anioIngresoFinal);
                    Console.Clear();
                } while (!validarFinal);

                if(anioIngresoFinal < anioIngresoInicio)
                {
                    anioAux = anioIngresoInicio;
                    anioIngresoInicio = anioIngresoFinal;
                    anioIngresoFinal = anioAux;
                }

                for(int i = anioIngresoInicio ; i < anioIngresoFinal ; i++)
                {
                    if( i % 4 == 0)
                    {
                        contadorViciesto++;
                        Console.WriteLine("{0}º anio biviesto = {1} ", contadorViciesto, i);
                    }
                    else
                    {
                        if(i % 100 == 0 && i % 400 == 0)
                        {
                            contadorViciesto++;
                            Console.WriteLine("{0}º anio biviesto = {1} ", contadorViciesto, i);
                        }
                    }
                }

                if(contadorViciesto == 0)
                {
                    Console.Clear();
                    Console.Write("No hay anios viciestos entre los anios {0} y {1}", anioIngresoInicio, anioIngresoFinal);
                }
                
                do
                {
                    Console.WriteLine("Desea ingresar otro anio? (Y/N)");
                    salir = Console.ReadKey();
                    Console.Clear();
                } while (salir.KeyChar != 'N' && salir.KeyChar != 'Y');
            } while (salir.KeyChar != 'N');

        }
    }
}
