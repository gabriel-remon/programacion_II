using System;
using System.Text;

namespace ejercicio5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int numeroIngreso = 0;
            StringBuilder cuadroTablas = new StringBuilder();

            Console.WriteLine("ingrese un entero");
            numeroIngreso = int.Parse(Console.ReadLine());
            cuadroTablas.AppendFormat("Tabla de multiplicar {0}", numeroIngreso);
            cuadroTablas.AppendLine("");

            for(int i=1; i<=10 ; i++)
            {
                cuadroTablas.AppendFormat("{0} x {1} = {2}", numeroIngreso, i, numeroIngreso * i);
                cuadroTablas.AppendLine("");
            }

            Console.WriteLine(cuadroTablas);
        }


    }
}
