﻿using System;

namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }
        }

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre):this(numero)
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return ((c1.Nombre == c2.Nombre) && (c1.Numero == c2.Numero));
        }
        public static bool operator != (Cliente c1, Cliente c2)
        {
            return  !(c1 == c2);
        }

    }
}
