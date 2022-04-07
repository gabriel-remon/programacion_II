using System;

namespace biblioteca
{
    public class validaror
    {

        public static bool ValidarRespuesta(ConsoleKeyInfo entrada)
        {
            return entrada.KeyChar == 'S' || entrada.KeyChar == 's';
        }

    }
}
