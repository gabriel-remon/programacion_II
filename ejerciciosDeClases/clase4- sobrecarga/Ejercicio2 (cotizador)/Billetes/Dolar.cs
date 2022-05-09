using System;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Dolar()
        {
            cotzRespectoDolar = 1;
        }

        public Dolar (double cantidad) 
        {
            this.cantidad = cantidad;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            Euro aux = new Euro(d.GetCantidad() * Euro.GetCotizacion());
            return aux;
        }

        public static explicit operator Peso(Dolar d)
        {
            Peso aux = new Peso(d.GetCantidad() * Peso.GetCotizacion());

            return aux;
        }

        public static implicit operator Dolar (double d)
        {
            Dolar aux = new Dolar(d);

            return aux;
        }

        
    }

}
