using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Torneo<T> where T : Equipo

    {
        private string nombre;
        private List<T> equipos;

        public Torneo()
        {
            equipos = new List<T>();
        }

        public Torneo(string nombre)
            :this()
        {
            this.nombre = nombre;
        }


        public string JugarPartido
        {
           get
           {
                Random random = new Random();
                int equipo1 = random.Next(0,equipos.Count);
                int equipo2 = random.Next(0,equipos.Count);

                return CalcularPartido(equipos[equipo1], equipos[equipo2]);
           }
        }

        public string mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(nombre);
            foreach(Equipo unEquipo in equipos)
            {
                retorno.AppendLine($"1 - {unEquipo.Firma()}");
            }
            return retorno.ToString();
        }

        public string CalcularPartido(T equipo1, T equipo2)
        {
            Random random = new Random();
            
            if(equipo1 is Equipo && equipo2 is Equipo)
            {
                return $"{equipo1} {random.Next(0, 10)} -" +
                         $" {random.Next(0, 10)} {equipo2}";
            }

            return "";
        }

        public static bool operator ==(Torneo<T> torneo , Equipo equipo)
        {
                foreach (T unEquipo in torneo.equipos)
                {
                    if (unEquipo == equipo)
                        return false;
                }
            return true;
          
        }

        public static bool operator !=(Torneo<T> torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }

        public static bool operator + (Torneo<T> torneo, Equipo equipo)
        {
            if (torneo != equipo)
            {
                torneo.equipos.Add((T)equipo);
                return true;
            }

            return false;
            
        }

    }
}
