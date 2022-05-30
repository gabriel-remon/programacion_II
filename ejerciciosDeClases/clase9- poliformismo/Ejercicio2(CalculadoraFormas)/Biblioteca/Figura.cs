using System;

namespace Biblioteca
{
    public abstract class Figura
    {
        public abstract double CalcularPeimetro();
        public abstract double CalcularSuperficue();
        public virtual string Dibujar()
        {
            return "Dibujando forma...";
        }
    }
}
