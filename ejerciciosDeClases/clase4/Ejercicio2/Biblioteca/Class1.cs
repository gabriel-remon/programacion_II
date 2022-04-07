using System;

namespace Billetes
{
    public class Pesos
    {
        double cantidad;
        double cotzRespectoDolar;

    }

    public class Euro
    {
        double cantidad;
        double cotzRespectoDolar;

    }

    public class Dolar
    {
        double cantidad;
        double cotzRespectoDolar;

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
            this.cotzRespectoDolar = 1;
        }

        public Dolar():this(0)
        { 
        }

    }
}
