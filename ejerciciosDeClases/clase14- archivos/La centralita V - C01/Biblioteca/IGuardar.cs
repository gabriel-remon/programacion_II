﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface IGuardar<T>
    {
        public string RutaDeArchivo { get; set; }
        public bool Guardar();
        public T Leer();

    }
}
