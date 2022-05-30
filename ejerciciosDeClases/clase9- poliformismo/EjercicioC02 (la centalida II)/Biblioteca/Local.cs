using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Local : Llamada
    {
        protected float costo;

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return this.costo * this.duracion;
        }

        public Local (Llamada llamada, float costo)
            :this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        { }

        public Local (string origen, float duracion, string destino, float costo)
            :base(duracion,destino,origen)
        {
            this.costo = costo;
        }

        protected override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(base.Mostrar());
            retorno.AppendLine($"Costo de la llamada: ${this.CostoLlamada}");

            return retorno.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }
    }
}
