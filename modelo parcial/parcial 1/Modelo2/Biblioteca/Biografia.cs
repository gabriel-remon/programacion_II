using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Biografia : Publicacion
    {
        protected override bool EsColor
        {
            get
            {
                return false;
            }
        }

        public override bool HayStock
        {
            get
            {
                if (stock > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public Biografia(string nombre)
            : this(nombre, 0, 0)
        {

        }

        public Biografia(string nombre, int stock)
            : this(nombre, stock, 0)
        {

        }

        public Biografia(string nombre, int stock, float valor)
            : base(nombre, stock, valor)
        {
        }

        public static explicit operator Biografia(string nombre)
        {
            return new Biografia(nombre);
        }

    }
}
