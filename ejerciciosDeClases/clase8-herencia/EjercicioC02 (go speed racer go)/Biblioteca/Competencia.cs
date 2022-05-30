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

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }

        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }

        public TipoCompetencia Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short canVueltas,short canCompetidores, TipoCompetencia tipo)
            :this()
        {
            this.cantidadVueltas = canVueltas;
            this.cantidadCompetidores = canCompetidores;
            this.tipo = tipo;
        }

        public string Mostraratos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Cantidad de competidores: {this.cantidadCompetidores}");
            retorno.AppendLine($"Cantidad de vueltas: {this.cantidadVueltas}");
            retorno.AppendLine($"Tipo de carrera: {tipo}");
            retorno.AppendLine("Competidores:");
            foreach(VehiculoDeCarrera unVehiculo in this.competidores)
            {
                retorno.AppendLine(unVehiculo.MostrarDatos());
            }

            return retorno.ToString();
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        { 
            foreach (VehiculoDeCarrera unVehiculo in c.competidores)
            {
                if(c.tipo==TipoCompetencia.F1)
                {
                    if (unVehiculo == a && (unVehiculo is AutoF1))
                    {
                        return true;
                    }
                }
                else
                {
                    if (unVehiculo == a && (unVehiculo is MotoCross))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }
            
        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        { 
            if(c!=a)
            {
                c.competidores.Add(a);
                return true;
            }

            return false;
        }
        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        { 
            if(c==a)
            {
                c.competidores.Remove(a);
                return true;
            }

            return false;
        }
     }
}
