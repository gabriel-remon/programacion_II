using System;

namespace fizzbass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 40; i++)
            {
                Console.WriteLine(i.FizzBuzz());
            }
        }
    }
}
