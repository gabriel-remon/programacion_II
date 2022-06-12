using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EjercicioC01__Lanzar_y_atrapar_
{
    public static class ArchivoTexto
    {
        public static void Guardar(string ruta, string texto)
        {
            try
            {
                using (StreamWriter archivo = new StreamWriter(ruta,false))
                {
                    archivo.WriteLine(texto);
                }
            }
            catch(Exception ex)
            {

            }
        }
        public static string Leer(string ruta)
        {
            if(File.Exists(ruta))
            {
                using(StreamReader archivo = new StreamReader(ruta))
                {
                    return archivo.ReadToEnd();
                }
            }
            else
            {
                throw new FileNotFoundException();
            }
            
        }
    }

}
