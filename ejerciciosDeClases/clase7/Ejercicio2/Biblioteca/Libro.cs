using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Libro
    {
        private List<String> paginas = new List<string>();

        public string this [int i]
        {
            get
            {
                string retorno = string.Empty;

                i = Math.Abs(i);

                if(i < this.paginas.Count)
                {
                    retorno = paginas [i];
                }

                return retorno;
            }
            set
            {
                i = Math.Abs(i);

                if(i >= this.paginas.Count)
                {
                    this.paginas.Add(value);
                }
                else
                {
                    this.paginas.Insert(i, value );
                }
            }
        }
    }
}
