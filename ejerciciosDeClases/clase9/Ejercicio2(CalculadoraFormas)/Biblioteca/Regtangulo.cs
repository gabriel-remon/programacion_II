using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Regtangulo : Figura
    {
        protected double lado1;
        double lado2;

        public Regtangulo (double lado1, double lado2)
        {
            this.lado1 = lado1; 
            this.lado2 = lado2; 
        }

        public override double CalcularPeimetro()
        {
            return (lado1 + lado2) * 2;
        }
        public override double CalcularSuperficue()
        {
            return lado1 * lado2;
        }
        public override string Dibujar()
        {
            return "Dibujando regtangulo";
        }
    }
}
