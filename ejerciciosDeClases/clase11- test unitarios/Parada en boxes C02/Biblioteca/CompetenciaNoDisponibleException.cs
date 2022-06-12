using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CompetenciaNoDisponibleException(string mensaje, string clase)
            :this(mensaje, clase, null)
        {
            
        }
        public CompetenciaNoDisponibleException(string mensaje, string clase,Exception innerEception)
            :base(mensaje,innerEception)
        {
            this.nombreClase = clase;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Exception en metodo{this.nombreMetodo} de la clase {this.nombreClase}");
            sb.AppendLine($"");
            sb.AppendLine($"");

            return sb.ToString();
        }

    }


}
