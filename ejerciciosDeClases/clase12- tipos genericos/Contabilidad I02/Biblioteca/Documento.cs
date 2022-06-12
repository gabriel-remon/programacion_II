using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Documento
    {
        public int documento;

        public Documento(int numero)
        {
            this.documento = numero;
        }

        public string NumeroDocumento
        {
            get
            {
                return this.documento.ToString();
            }
        }
    }
}
