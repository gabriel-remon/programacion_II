﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CentralitaExcepcion :Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }

        public CentralitaExcepcion(string mensaje, string clase, string metodo)
            :this(mensaje,clase,metodo,null)
        {
        }
        public CentralitaExcepcion(string mensaje, string clase, string metodo,Exception innerExcepcion)
            :base(mensaje, innerExcepcion)
        {
            this.nombreMetodo = metodo;
            this.nombreClase = clase;
        }

    }
}
