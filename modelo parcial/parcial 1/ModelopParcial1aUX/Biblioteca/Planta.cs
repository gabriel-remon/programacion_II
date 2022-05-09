using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;

        public int Tamanio
        {
            get
            {
                return this.tamanio;
            }
        }

        public abstract bool TieneFlores { get; }

        public abstract bool TieneFruto { get; }

        protected Planta(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }

        public virtual string ResumenDeDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"{this.nombre} tiene un tamaño de {tamanio}");
            retorno.AppendLine(String.Format("tiene flores {0}",this.TieneFlores?"SI":"NO"));
            retorno.AppendLine(String.Format("tiene flores {0}", this.TieneFruto? "SI" : "NO"));

            return retorno.ToString();
        }

    }
}

