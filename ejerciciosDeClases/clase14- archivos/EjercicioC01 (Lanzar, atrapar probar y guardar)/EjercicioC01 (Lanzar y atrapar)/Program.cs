using System;

namespace EjercicioC01__Lanzar_y_atrapar_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime horaActual = DateTime.Now;
            string rutaDestino = horaActual.Year.ToString() + horaActual.Month.ToString() + horaActual.Day.ToString() + "-" + horaActual.Hour.ToString() + horaActual.Minute.ToString();
            rutaDestino = "D:\\programacion\\programacion_II\\ejerciciosDeClases\\clase14- archivos\\EjercicioC01 (Lanzar, atrapar probar y guardar)\\Archivos\\" + rutaDestino+".txt";
            
            try
            {
                OtraClase otraClase = new OtraClase();
            }
            catch(Exception ex)
            {
                ArchivoTexto.Guardar(rutaDestino, ex.InnerException.ToString());
                Console.WriteLine(Environment.CurrentDirectory);
            }

            Console.WriteLine(ArchivoTexto.Leer(rutaDestino));
            
        }
    }
}
