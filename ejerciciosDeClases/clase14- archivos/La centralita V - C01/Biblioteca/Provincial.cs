using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum Franja
    {
        Franja_1,
        Franja_2,
        Franja_3
    }
    public class Provincial : Llamada
    {

        protected Franja franjaHoraria;

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public string Leer()
        {
            throw new NotImplementedException();
        }
        public override float CostoLlamada
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
            ;
        }

        protected override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(base.Mostrar());
            retorno.Append($"La franja horaria es: {franjaHoraria}");
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

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }
    }
}
