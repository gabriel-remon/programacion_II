using System;
using System.Text;
namespace Centralita
{
    public class Local: Llamada
    {
        protected float costo; 

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return costo * duracion; 
        }

        public Local(Llamada llamada, float costo):this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public override string Mostrar()
        {
            StringBuilder retono = new StringBuilder();

            retono.AppendLine($"{base.Mostrar()}");
            retono.AppendLine($"Costo de la llamada: ${this.CostoLlamada}");

            return retono.ToString();
            
        }
    }
}
