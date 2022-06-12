using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Lapiz: IAcciones
    {
        private float tamanioMina;

        public Lapiz(int tamanioMina)
        {
            this.tamanioMina = (float)tamanioMina;
            
        }

        public ConsoleColor Color
        {
            get
            { 
                return ConsoleColor.Gray;
            }
            set 
            { 
                throw new NotImplementedException();
            }
        }
        public float UnidaddesDeEscritura
        {
            get 
            { 
                return tamanioMina;
            }
            set 
            {
                if (value >= 0)
                {
                    this.tamanioMina = value;
                }
            }
        }

        public bool Recargar(int unidades)
        {
            if (unidades >= 0)
            {
                this.tamanioMina =+ unidades;
                return true;
            }
            return false;
        }

        public EscrituraWrapper Escribir(string texto)
        {
        
            float cantidadDescuento = texto.Replace(" ", string.Empty).Length * 0.1f;
            if (tamanioMina >= cantidadDescuento)
                tamanioMina = tamanioMina - cantidadDescuento;
            return new EscrituraWrapper(texto, this.Color);
        }
        public override string ToString()
        {
            return $"Lapiz, Color de eschitura: {this.Color} -" +
                   $"Cantidad de tinta:{this.UnidaddesDeEscritura}";
        }

    }
}
