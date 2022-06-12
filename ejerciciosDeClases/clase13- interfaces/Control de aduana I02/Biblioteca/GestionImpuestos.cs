using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class GestionImpuestos
    {
        private List<IAduana> impuestosAduana;
        private List<IAfip> impuestosAfip;

        public GestionImpuestos()
        {
            this.impuestosAduana = new List<IAduana>();
            this.impuestosAfip =new List<IAfip>();
        }
        public decimal CalcularTotalImpuestosAduana()
        {
            decimal totalImpuestosAduana = 0;
            foreach (IAduana unPaquete in this.impuestosAduana)
            {
                totalImpuestosAduana = totalImpuestosAduana + unPaquete.Impuestos;
            }

            return totalImpuestosAduana;

        }

        public decimal CalcularTotalImpuestosAfip() 
        {
            decimal totalImpuestosAfip = 0;
            foreach (IAfip unPaquete in this.impuestosAfip)
            {
                totalImpuestosAfip = totalImpuestosAfip + unPaquete.Impuestos;
            }

            return totalImpuestosAfip;
        }

        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes) 
        {
            foreach (Paquete unPaquete in paquetes)
            {
                this.RegistrarImpuestos(unPaquete);
            }
        }
        public void RegistrarImpuestos(Paquete paquete)
        {
            this.impuestosAduana.Add(paquete);
            if (paquete is IAfip)
                this.impuestosAfip.Add((IAfip)paquete);
        }
    }
}
