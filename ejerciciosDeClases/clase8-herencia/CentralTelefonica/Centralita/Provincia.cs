using System;
using System.Text;

namespace Centralita
{
    public class Provincia : Llamada
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
            float multiplicador = 1;

            switch(franjaHoraria)
            {
                case Franja.Franja_1:
                    multiplicador = 0.99f;
                    break;

                case Franja.Franja_2:
                    multiplicador = 1.25f;
                    break;

                case Franja.Franja_3:
                    multiplicador = 0.66f;
                    break;
            }

            return multiplicador * this.Duracion; 
        }

        public Provincia(Franja miFranja, Llamada llamada)
            :this(llamada.NroOrigen,miFranja,llamada.Duracion, llamada.NroDestino)
        {
        }

        public Provincia(string origen, Franja miFranja, float duracion, string destino)
            :base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }

        public override string Mostrar()
        {
            StringBuilder retono = new StringBuilder();

            retono.AppendLine($"{base.Mostrar()}");
            retono.AppendLine($"costo de la llamada{this.CostoLlamada}");

            return retono.ToString();

        }

    
    }
}
