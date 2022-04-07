using System;
using Biblioteca;
using System.Text;
using System.Text.RegularExpressions;

namespace EjercicioA01
{
    class Program
    {
        static void Main(string[] args)
        {
            Conductores[] listaConductores = new Conductores[3];

            
            for (int i = 0; i<2; i++)
            {
                Console.WriteLine("Ingrese los datos del {0}º conductor\n\n", i + 1);
                listaConductores[i] = CargarConductor();
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(DetallesConductor(listaConductores[i]));
            }
            
        }

        /// <summary>
        /// pide por consola valores y los guarda en el objeto conductores
        /// </summary>
        /// <param name="conductorIngreso"></param>
        /// <returns></returns>
        private static Conductores CargarConductor()
        {
            Conductores conductorAux = new Conductores();

            Console.WriteLine("Ingrese el nombre del conductor");
            conductorAux.SetNombreConductor(Console.ReadLine());
            for(int i =0; i<7; i++)
            {
                Console.WriteLine("Ingrese la cantidad de Km que realizo el dia {0}", DiaSemana(i));
                conductorAux.SetKmDiarios(i, int.Parse(Console.ReadLine()));
                Console.Clear();
            }

            return conductorAux;

        }

        /// <summary>
        /// transforma un numero del 0 al 6 en los dias de la semana
        /// de lunes a viernes
        /// </summary>
        /// <param name="numeroDia"></param>
        /// <returns></returns>
        private static string DiaSemana(int numeroDia)
        {
            string retorno = "No es un dia";
            switch(numeroDia)
            {
                case 0:
                    retorno = "lunes";
                    break;

                case 1:
                    retorno = "martes";
                    break;

                case 2:
                    retorno = "miercoles";
                    break;

                case 3:
                    retorno = "jueves";
                    break;

                case 4:
                    retorno = "viernes";
                    break;

                case 5:
                    retorno = "sabado";
                    break;

                case 6:
                    retorno = "domingo";
                    break;
            }

            return retorno;
        }


        /// <summary>
        /// Muestra por pantalla los detalles de un solo conductor 
        /// </summary>
        /// <param name="conductorIngreso"></param>
        /// <returns></returns>
        private static string DetallesConductor(Conductores conductorIngreso)
        { 
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat("El nombre es: {0}", conductorIngreso.GetNombre());
            retorno.AppendLine();
            for(int i = 0; i<7; i++)
            {
                retorno.AppendFormat("Dia {0}: {1}Km", DiaSemana(i), conductorIngreso.GetKmUnDia(i));
                retorno.AppendLine();
            }

            return retorno.ToString();
        }
    }
}
