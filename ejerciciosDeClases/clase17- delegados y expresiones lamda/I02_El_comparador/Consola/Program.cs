using System;
using System.Collections.Generic;
using static System.Environment;

namespace Consola
{
    class Program
    {
        public delegate int DelegadoComparacion(string primerTexto, string segundoTexto);

        static void Main(string[] args)
        {
            
            string primerTexto = "Vive como si fueras a morir mañana; aprende como si el mundo fuera a durar para siempre.";
            // Cant. caracteres: 88, Cant. palabras: 17 , Cant. vocales: 34, Cant. signos puntuación: 2 
            string segundoTexto = "La vida es como montar en bicicleta; para mantener el equilibrio debes seguir moviéndote.";
            // Cant. caracteres: 89, Cant. palabras: 13, Cant. vocales: 35, Cant. signos puntuación: 2

            DelegadoComparacion CantidadLetras = (ptxt, stxt) => ptxt.Length - stxt.Length;

            DelegadoComparacion CantidadPalabras = (ptxt, stxt) =>
                ptxt.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length
               - stxt.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;

            DelegadoComparacion CantidadVocales = (ptxt, stxt) => ContarVocales(ptxt) - ContarVocales(stxt);

            DelegadoComparacion CantidadSignosPuntuacion = (ptxt, stxt) => ContarSignosPuntuacion(ptxt) - ContarSignosPuntuacion(stxt);

            

            /*/
            Console.WriteLine("Ingrese el primer texto:");
            string primerTexto = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo texto:");
            string segundoTexto = Console.ReadLine();
            //*/

            Console.WriteLine($"{NewLine}1era Comparación - Texto con más caracteres:");
            Comparar(CantidadLetras, primerTexto, segundoTexto);
            // Punto 2

            Console.WriteLine($"{NewLine}2da Comparación - Texto con más palabras:");
            Comparar(CantidadPalabras,primerTexto, segundoTexto);
            // Punto 3

            Console.WriteLine($"{NewLine}3era Comparación - Texto con más vocales:");
            Comparar(CantidadVocales, primerTexto, segundoTexto);
            // Punto 4

            Console.WriteLine($"{NewLine}4ta Comparación - Texto con más signos de puntuación:");
            Comparar(CantidadSignosPuntuacion, primerTexto, segundoTexto);
            // Punto 5
        }
        public static void Comparar(DelegadoComparacion delegado, string text1, string text2)
        {
            int comparacion = delegado(text1, text2);

            if(comparacion > 0)
            {
                Console.WriteLine("El primer texto es mayor al segundo");
            }
            else if(comparacion < 0)
            {
                Console.WriteLine("El segundo texto es mayor al primero");
            }
            else
            {
                Console.WriteLine("Los textos son iguales");

            }
        }

      
        public static int ContarVocales(string texto)
        {
            List<char> vocales = new List<char>()
            {
                'a', 'á', 'A', 'Á', 'e', 'é', 'E', 'É',
                'i', 'í', 'I', 'Í', 'o', 'ó', 'O', 'Ó',
                'u', 'ú', 'U', 'Ú'
            };

            return ContarCaracteres(texto, vocales);
        }

        public static int ContarSignosPuntuacion(string texto)
        {
            List<char> signosPuntuacion = new List<char>()
            {
                '.', ';', ','
            };

            return ContarCaracteres(texto, signosPuntuacion);
        }

        public static int ContarCaracteres(string texto, List<char> caracteres)
        {
            int cantidadCaracteres = 0;

            foreach (char caracter in texto)
            {
                if (caracteres.Contains(caracter))
                {
                    cantidadCaracteres++;
                }
            }

            return cantidadCaracteres;
        }
    }
}
