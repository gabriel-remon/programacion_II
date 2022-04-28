using System;

namespace Biblioteca
{
    public class Automovil:VehiculosTerrestre
    {
        public short cantidadMarchas;
        public int cantidadPasajeros;


        public Automovil (short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

    }
}
