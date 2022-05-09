using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Banano : Planta
    {
        private string codigo;

        public override bool TieneFlores { get { return true; } }

        public override bool TieneFruto { get { return true; } }

        public Banano (string nombre, int tamanio, string codigo)
            :base(nombre,tamanio)
        {
            this.codigo = codigo;
        }

        public override string ResumenDeDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(base.ResumenDeDatos());
            retorno.AppendLine($"codigo internacional: {this.codigo}");

            return retorno.ToString();
        }

    }
}
