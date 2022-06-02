using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Cuadrado : Regtangulo
    {
        public Cuadrado(double lado) : base(lado, lado)
        {
        }

        public override double CalcularPeimetro()
        {
            return lado1 * 4;
        }
        public override double CalcularSuperficue()
        {
            return lado1 *lado1;
        }

    }
}
