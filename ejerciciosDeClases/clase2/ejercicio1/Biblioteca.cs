﻿using System;
namespace ejercicio1
{
    public static class Validador
    {
        
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno = false;

            if(valor >= min && valor <= max)
            {
                retorno = true;
            }

            return retorno;
        }

    }
}
