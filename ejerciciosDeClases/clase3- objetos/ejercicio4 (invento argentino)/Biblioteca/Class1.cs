using System;
using System.Text;

namespace Biblioteca
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        ConsoleColor color;
        short tinta;

        public Boligrafo(short tintaIngreso, ConsoleColor colorIngreso)
        {
            this.tinta = tintaIngreso;
            this.color = colorIngreso;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tintaIngreso)
        {
            int recargaAux;

            recargaAux = tinta + tintaIngreso;

            if(recargaAux>=0 && recargaAux <=100)
            {
                this.tinta = (short)recargaAux;
            }
        }

        public void Recargar()
        {
            int recarga;
            recarga = 100 - tinta;
            if(recarga>0)
            {
                SetTinta((short)recarga);
            }
        }

        public void Pintar(short gasto, out string dibujo)
        {
            string dibujoTxt = "" ;
            int gastoInt = gasto;
          
            if(gastoInt>=tinta)
            {
                gastoInt = tinta;
            }

            dibujoTxt=dibujoTxt.PadLeft(gastoInt, '*');

            gastoInt = gastoInt * -1;
            SetTinta((short)gastoInt);

            dibujo = dibujoTxt;
        }
    }
}
