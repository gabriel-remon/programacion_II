using System;
using Biblioteca;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafo1 = new Boligrafo(100,ConsoleColor.Blue);
            Boligrafo boligrafo2 = new Boligrafo(50,ConsoleColor.Red);
            string dibujo;
            short auxiliar = 0;

            do
            {
                do
                {
                    Console.Clear();
                    auxiliar = 0;
                    Console.WriteLine("Ingrese que boligrafo quiere usar 1 o 2");
                    short.TryParse(Console.ReadLine(), out auxiliar);

                } while (auxiliar == 0);

                if(auxiliar==1)
                {
                    Console.WriteLine("carga del boligrafo 1 : {0}", boligrafo1.GetTinta());
                    Console.WriteLine("Ingrese cuanto desea pintar");

                    Console.ForegroundColor = boligrafo1.GetColor();
                    boligrafo1.Pintar(short.Parse(Console.ReadLine()), out dibujo);
                    Console.WriteLine("Desea recargar? (S/N)");

                    if ((Console.ReadKey(true)).KeyChar == 's')
                    {
                        boligrafo1.Recargar();
                    }
                }
                else
                {
                    Console.WriteLine("carga del boligrafo 2 : {0}", boligrafo2.GetTinta());
                    Console.WriteLine("Ingrese cuanto desea pintar");

                    Console.ForegroundColor = boligrafo2.GetColor();
                    boligrafo2.Pintar(short.Parse(Console.ReadLine()), out dibujo);

                    Console.WriteLine("Desea recargar? (S/N)");
                    if((Console.ReadKey(true)).KeyChar =='s')
                    {
                        boligrafo2.Recargar();
                    }
                }

                Console.WriteLine(dibujo);
                

                Console.WriteLine("Desea continuar? (S/N)");

            } while ((Console.ReadKey()).KeyChar == 's');


        }
    }
}
