using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Rosal : Planta
    {
        public enum Color
        {
            Roja,
            Blanca,
            Amarilla,
            Rosa,
            Azul
        }

        private Color florColor;

        public override bool TieneFlores { get { return true; } }
       
        public override bool TieneFruto { get { return false; } }

        public Rosal (string nombre, int tamanio)
            :this(nombre,tamanio,Color.Rosa)
        {

        }

        public Rosal (string nombre, int tamanio, Color flor)
            :base(nombre, tamanio)
        {
            this.florColor = flor;
        }

        public override string ResumenDeDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(base.ResumenDeDatos());
            retorno.AppendLine($"Flores de color {florColor}");

            return retorno.ToString();
        }
    }
}
