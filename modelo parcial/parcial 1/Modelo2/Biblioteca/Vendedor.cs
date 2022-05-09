using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;

        public static string ObtenerINformacionDeVentas(Vendedor vendedor)
        {
            StringBuilder retorno = new StringBuilder();
            float gananciaTotoal = 0;

            retorno.AppendLine(vendedor.ToString());
            foreach (Publicacion unaPuclicacion in vendedor.ventas)
            {
                retorno.AppendLine("--------------------------");
                retorno.AppendLine(unaPuclicacion.ObtenerInformacion());
                gananciaTotoal += unaPuclicacion.Importe;
            }

            retorno.AppendLine($"Ganancia total: {gananciaTotoal}");
            return retorno.ToString();
        }


        private Vendedor()
        {
            this.ventas = new List<Publicacion>();           
        }

        public Vendedor(string nombre):this()
        {
            this.nombre = nombre;
        }
    }
}
