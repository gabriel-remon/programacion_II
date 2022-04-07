using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 0;
            double suma = 0;
            bool flagPerfecto = false;
            int contador = 0;

            while(contador<4)
            {
                numero++;
                suma = 0;
                flagPerfecto = false;
                for(double i = numero-1; i>0;i--)
                {
                    if(numero % i == 0)
                    {
                        suma = suma + i;
                    }
                    if(suma > numero)
                    {
                        break;
                    }
                    if(numero==suma && i==1)
                    {
                        flagPerfecto = true;
                    }
                }

                if(flagPerfecto)
                {
                    Console.WriteLine("El {0}º numero perfecto es {1}",contador=1,numero);
                    contador++;
                }
            }
                Console.ReadKey();
        }
    }
}
