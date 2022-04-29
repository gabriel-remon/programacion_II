using System;
using System.Text;

namespace Centralita
{
    public enum TipoLLamada
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

        public float Duracion
        {
            get
            {
                return duracion;
            }
        }


        public string NroDestino
        {
            get
            {
                return NroDestino;
            }
        }


        public string NroOrigen
        {
            get
            {
                return nroOrigen;
            }
        }


        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroOrigen = nroOrigen;
            this.nroDestino = nroDestino;
        }

        public virtual string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Duracion de la llamada: {duracion} minutos");
            retorno.AppendLine($"Numero de origen: {nroOrigen}");
            retorno.AppendLine($"Numero de destino {nroDestino}");

            return retorno.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;

            if (llamada1.duracion > llamada2.duracion)
                retorno = 1;
            else if (llamada1.duracion < llamada2.duracion)
                retorno = -1;

            return retorno;
        }
    }
}
