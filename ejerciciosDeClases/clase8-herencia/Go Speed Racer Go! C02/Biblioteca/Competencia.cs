using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Competencia
    {
        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();  
        }
        public Competencia(short cantidadVueltas,short cantidadCompetidores,TipoCompetencia tipo)
            :this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores= cantidadCompetidores;
            this.tipo = tipo;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad de competidores: {this.cantidadCompetidores}");
            sb.AppendLine($"Cantidad de vueltas {this.cantidadVueltas}");
            sb.AppendLine($"Tipo de carrera: {this.tipo.ToString()}");
            sb.AppendLine("Lista de competidores:\n");


            foreach(VehiculoDeCarrera unVehiculo in this.competidores)
            {
                sb.AppendLine($"{unVehiculo.MostrarDatos()} \n");   
            }

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

        public static bool operator == (Competencia c, VehiculoDeCarrera a)
        {
            bool retorno = false;

            if ((c.tipo == Competencia.TipoCompetencia.F1 && a.GetType() == typeof(AutoF1) ||
                (c.tipo == Competencia.TipoCompetencia.MotoCross && a.GetType() == typeof(MotoCross))
            {
                if (c.competidores.Count > 0)
                    foreach (VehiculoDeCarrera unAuto in c.competidores)
                    {
                        if (unAuto == a)
                        {
                            retorno = true;
                            break;
                        }
                    }
            }
            else
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }
    }
}
