using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }
    public abstract class Llamada
    {
        
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public abstract float CostoLlamada { get; }

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public Llamada (float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
    
        protected virtual string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Duracion: {this.duracion}");
            retorno.AppendLine($"Numero de origen: {this.nroOrigen}");
            retorno.AppendLine($"Numero de destino: {this.nroDestino}");

            return retorno.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if(llamada1.duracion > llamada2.duracion)
            {
                return 1;
            }
            else if (llamada1.duracion < llamada2.duracion)
            {
                return -1;
            }

            return 0;
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return (l1.Equals(l2)) && (l1.nroOrigen == l2.nroOrigen) && (l1.nroDestino == l2.nroDestino);
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
    }
}
