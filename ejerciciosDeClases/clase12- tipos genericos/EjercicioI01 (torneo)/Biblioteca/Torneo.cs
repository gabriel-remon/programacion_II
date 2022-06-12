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
                int equipo2;
                do
                {
                    equipo2 = random.Next(0, equipos.Count);
                } while (equipo1 == equipo2);
                return CalcularPartido(equipos[equipo1], equipos[equipo2]);
           }
        }

        public string mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(this.nombre);
            foreach(T unEquipo in this.equipos)
            {
                retorno.AppendLine($"1 - {unEquipo.Firma()}");
            }
            return retorno.ToString();
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random random = new Random();
            
            
            return $"{equipo1.ToString()} {random.Next(0, 10)} -" +
                   $" {random.Next(0, 10)} {equipo2.ToString()}";

        }

        public static bool operator ==(Torneo<T> torneo , T equipo)
        {
                foreach (T unEquipo in torneo.equipos)
                {
                    if (unEquipo == equipo)
                        return true;
                }
            return false;
          
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static Torneo<T> operator + (Torneo<T> torneo, T equipo)
        {
            if (torneo != equipo)
            {
                torneo.equipos.Add(equipo);
                return torneo;
            }

            return torneo;
            
        }

    }
}
