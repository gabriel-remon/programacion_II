using System;

namespace ejercicio1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int numeroIngreso;
            int min=0;
            int max=0;
            float promedio;
            int total=0;
            int repetidor = 5;

            for(int i=repetidor; i>0; i--)
            {
                Console.WriteLine("Ingrese un numero");
                numeroIngreso = int.Parse(Console.ReadLine());
                if(i==repetidor)
                {
                    min = numeroIngreso;
                    max = numeroIngreso;
                }
                else
                {
                    if(numeroIngreso > max)
                    {
                        max = numeroIngreso;
                    }
                    else
                    {
                        if(numeroIngreso< min)
                        { 
                            min = numeroIngreso;
                        }
                        
                    }
                }
                total = total + numeroIngreso;
            }
            if(total>0)
            {
                promedio = (float) total / repetidor;
            }
            else
            {
                promedio = 0;
            }
            
            Console.WriteLine("El nuemro minimo es {0}", min);
            Console.WriteLine("El nuemro maximo es {0}", max);
            Console.WriteLine("El promedio es {0}", promedio);

        }

    }
}
