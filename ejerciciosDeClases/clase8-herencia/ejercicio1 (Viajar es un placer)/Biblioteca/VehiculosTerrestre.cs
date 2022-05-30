using System;
namespace Biblioteca
{
    public class VehiculosTerrestre
    {
        public short cantidadRuedas;
        public short cantidadPuertas;
        public Colores color;

        public VehiculosTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadPuertas = cantidadPuertas;
            this.cantidadRuedas = cantidadRuedas;
            this.color = color;
        }
    }

    public enum Colores
    {
        Rojo,
        Blanco,
        Azul,
        Gris,
        Negro
    }


}
