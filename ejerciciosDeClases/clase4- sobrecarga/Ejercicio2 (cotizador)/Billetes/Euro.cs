using System;
namespace Billetes
{
    public class Euro
    {
       
        private double cantidad;
        private static double cotzRespectoDolar;

        static Euro()
        {
            cotzRespectoDolar = 0.92;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro (double cantidad, double cotizacion):this (cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        public static explicit operator Dolar (Euro e)
        {
            return new Dolar(e.GetCantidad() / Euro.GetCotizacion());
        }

        public static explicit operator Peso (Euro e)
        {
            Dolar aux = (Dolar)e;
            return new( (Peso) aux);
        }

    }
}

