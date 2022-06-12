using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Paquete :IAduana
    {
        private string codigoSeguimiento;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double peroKg;

        public abstract bool TienePrioridad { get; }
        public decimal Impuestos
        {
            get
            {
                return costoEnvio * 0.35M;
            }
        }
        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double peroKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.peroKg = peroKg;
        }
    
        public virtual decimal AplicarImpuestos()
        {
            return this.Impuestos + this.costoEnvio;
        }

        public string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Codigo de Seguimiento: N° {this.codigoSeguimiento}");
            sb.AppendLine($"Costo de envio: {this.costoEnvio} $");
            sb.AppendLine(String.Format("Tiene prioridad: {0}",this.TienePrioridad? "Si":"No"));
            sb.AppendLine($"Destino : {this.destino}");
            sb.AppendLine($"Origen: {this.origen}");
            sb.AppendLine($"Peso en kilos: {this.peroKg} kg");

            return sb.ToString();
        }
    }

}
