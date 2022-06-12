using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface IAcciones
    {
        public ConsoleColor Color { get; set; }
        public float UnidaddesDeEscritura { get; set; }

        public EscrituraWrapper Escribir(string texto);

        public bool Recargar(int unidades);

    }
}
