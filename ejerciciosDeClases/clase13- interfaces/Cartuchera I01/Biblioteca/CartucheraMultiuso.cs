using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CartucheraMultiuso
    {
        public List<IAcciones> acciones;

        public CartucheraMultiuso()
        {
            this.acciones = new List<IAcciones>();
        }

        public bool RecorrerElementos()
        {
            float unidadesAnteriores = 0;
            bool recargaTotal = true;

            foreach(var accion in acciones)
            {
                unidadesAnteriores = accion.UnidaddesDeEscritura;
                accion.Escribir("a");
                if(accion.UnidaddesDeEscritura == unidadesAnteriores && recargaTotal)
                {
                    recargaTotal = false;
                }

            }
            if (!recargaTotal)
            {
                foreach(var accion in acciones)
                {
                    accion.Recargar(20);
                }
            }

            return recargaTotal;
        }
    }
}
