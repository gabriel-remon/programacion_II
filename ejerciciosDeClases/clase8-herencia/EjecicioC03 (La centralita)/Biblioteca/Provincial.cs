using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float costo;

            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    costo= 0.99f;
                    break;

                case Franja.Franja_2:
                    costo = 1.25f;
                    break;

                default:
                    costo = 0.66f;
                    break;
            }

            return costo * this.duracion;
        }

        public override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(base.Mostrar());
            retorno.AppendLine($"Costo de la llamada: ${ this.CostoLlamada}");

            return retorno.ToString();
        }

        public Provincial(Franja miFranja, Llamada llamada)
            :this(llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroDestino)
        { }
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :base(duracion, destino,origen)
        {
            this.franjaHoraria = miFranja;
        }

    }
}
