using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public int PartidosJugados
        {
            get
            {
                return partidosJugados;
            }
            set
            {
                this.partidosJugados = value;
            }
        }

        public float PromedioGoles
        {
            get
            {
                return totalGoles / partidosJugados;
            }
        }

        public int TotalGoles
        {
            get
            {
                return totalGoles;
            }
            set
            {
                this.totalGoles = value;
            }
        }

        public Jugador (int dni, string nombre)
            :this(dni,nombre,0,0)
        { }

        public Jugador(int dni,string nombre, int totalGoles, int totalPartidos )
            :base(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public override string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(base.MostrarDatos());
            retorno.AppendLine($"Partidos Jugados: {this.PartidosJugados}");
            retorno.AppendLine($"Goles realizados: {this.TotalGoles}");
            retorno.AppendLine($"Promedio de goles: {this.PromedioGoles}");

            return retorno.ToString();
        }

        public static bool operator == (Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }
        public static bool operator != (Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
