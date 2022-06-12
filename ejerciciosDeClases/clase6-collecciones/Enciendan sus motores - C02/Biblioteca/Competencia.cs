using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;
        

        private Competencia()
        {
            competidores = new List<AutoF1>();  
        }
        public Competencia(short cantidadVueltas,short cantidadCompetidores)
            :this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores= cantidadCompetidores;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            Random r = new Random();

            if(c!=a && c.competidores.Count < c.cantidadCompetidores)
            {
                a.EnCampotencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadCombustible = (short) r.Next(15, 100);


                c.competidores.Add(a);
                return true;
            }
            return false;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            if (c == a)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }

        public static bool operator == (Competencia c, AutoF1 a)
        {
            foreach(AutoF1 unAuto in c.competidores)
            {
                if(unAuto==a)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
    }
}
