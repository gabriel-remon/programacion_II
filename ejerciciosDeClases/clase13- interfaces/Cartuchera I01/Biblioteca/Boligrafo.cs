using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Boligrafo :IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;
    
        public Boligrafo(int tinta, ConsoleColor colorTinta)        
        {
            this.colorTinta = colorTinta;
            this.tinta = (float) tinta;
        }

        public ConsoleColor Color
        {
            get 
            { 
                return colorTinta;
            }
            set 
            {
                if(value >= 0)
                    colorTinta = value; 
            }
        }

        public bool Recargar(int unidades)
        {

            if (unidades >= 0)
            {
                this.tinta =+ unidades;
                return true;
            }
            return false;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            float cantidadDescuento = texto.Replace(" ", string.Empty).Length * 0.3f;
            if(tinta>= cantidadDescuento)
                tinta = tinta - cantidadDescuento;
            return new EscrituraWrapper(texto,this.Color);
        }

        public float UnidaddesDeEscritura
        {
            get { return tinta; }
            set { tinta = value; }
        }

        public override string ToString()
        {
            return $"Boligrafo, Color de eschitura: {this.Color} -" +
                   $"Cantidad de tinta:{this.UnidaddesDeEscritura}";
        }

    }
}
