using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{

    public sealed class Circulo : Figura
    {
        double radio;

        public Circulo (double radio)
        {
            this.radio = radio;
        }

        public override double CalcularPeimetro()
        {
            return 2 * Math.PI * radio;
        }
        public override double CalcularSuperficue()
        {
            return Math.PI * radio * radio;
        }
        public override string Dibujar()
        {
            return "Dibujando circulo";
        }
    }
}
