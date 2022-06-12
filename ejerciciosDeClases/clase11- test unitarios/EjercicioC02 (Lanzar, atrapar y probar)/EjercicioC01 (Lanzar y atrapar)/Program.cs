using System;

namespace EjercicioC01__Lanzar_y_atrapar_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase otraClase = new OtraClase();
            }
            catch(Exception ex)
            {

                Console.WriteLine(ex.InnerException);
            }
        }
    }
}
