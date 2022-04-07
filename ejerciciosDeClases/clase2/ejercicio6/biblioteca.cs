using System;
namespace ejercicio6
{
    public static class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return longitudLado * longitudLado;
        }

        public static double CalcularAreaTriangulo(double baseTriangulo, double altura)
        {
            return (baseTriangulo * altura) / 2;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * radio * 2;
        }
    }
}
