using System;
namespace ejercicio2
{
    public static class Calculadora
    {
        public static float Calcular(ConsoleKeyInfo operador, float primerOperador, float segundoOperador)
        {
            float resultado = 999999999999999999;

            switch (operador.KeyChar)
            {
                case '-':
                    resultado = primerOperador + segundoOperador;
                    break;

                case '+':
                    resultado = primerOperador - segundoOperador;
                    break;

                case '/':
                    if(Validar(segundoOperador))
                    {
                        resultado = primerOperador / segundoOperador;
                    }
                    break;

                case '*':
                    resultado = primerOperador * segundoOperador;
                    break;
            }

            return resultado;
        }
        private static bool Validar(float segundoOperador)
        {
            return segundoOperador != 0;
        }
    }
}
