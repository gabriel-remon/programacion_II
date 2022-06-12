using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CartucheraSimple
    {
        public List<Boligrafo> boligrafos;
        public List<Lapiz> lapices;

        public CartucheraSimple()
        {
            this.boligrafos = new List<Boligrafo>();
            this.lapices = new List<Lapiz>();
        }

        public bool RecorrerElementos()
        {
            float unidadesAnteriores = 0;
            bool recargaTotal = true;

            foreach (Boligrafo unBoligrafo in boligrafos)
            {
                unidadesAnteriores = unBoligrafo.UnidaddesDeEscritura;
                unBoligrafo.Escribir("a");
                if (unBoligrafo.UnidaddesDeEscritura == unidadesAnteriores && recargaTotal)
                {
                    recargaTotal = false;
                }

            }
            foreach (Lapiz unLapiz in lapices)
            {
                unidadesAnteriores = unLapiz.UnidaddesDeEscritura;
                unLapiz.Escribir("a");
                if (unLapiz.UnidaddesDeEscritura == unidadesAnteriores && recargaTotal)
                {
                    recargaTotal = false;
                }

            }
            if (!recargaTotal)
            {
                foreach (Boligrafo unBoligrafo in boligrafos)
                {
                    unBoligrafo.Recargar(20);
                }
                foreach(Lapiz unLapiz in lapices)
                {
                    unLapiz.Recargar(20);
                }
            }

            return recargaTotal;
        }
    }
}
