using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int numeroIngreso = 0;
            int total = 0;
            int min = 0;
            int max = 0;
            int promedio = 0;

            do
            {
                
                Console.WriteLine("Ingrese un numero entre -100 y 100");
                numeroIngreso = int.Parse(Console.ReadLine());
                Console.Clear();
                if (Validador.Validar(numeroIngreso, -100, 100))
                {
                  
                    if(contador==0)
                    {
                        min = numeroIngreso;
                        max = numeroIngreso;
                    }
                    else
                    {
                        if(numeroIngreso<min)
                        {
                            min = numeroIngreso;
                        }
                        else
                        {
                            if(numeroIngreso>max)
                            {
                                max = numeroIngreso;
                            }
                        }
                    }
                    total = total + numeroIngreso;
                    contador++;
                    
                }
                else
                {
                    Console.WriteLine("Error");
                }


            } while (contador < 10);

            promedio = total / 10;
            Console.Clear();
            Console.WriteLine("El numero menor es: {0}\n el numero mayor es:{1}\n el promedio es:{2}", min, max, promedio);
            Console.ReadKey(true);
        }
    }
}
