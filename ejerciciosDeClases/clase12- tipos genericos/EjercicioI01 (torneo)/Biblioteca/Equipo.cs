using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Equipo
    {
        protected string nombre;
        protected DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public string Firma()
        {
            return $"{this.nombre} fundado el {this.fechaCreacion.ToString("d")}";
        }

        public static bool operator == (Equipo equipo1, Equipo equipo2) 
        {
            return equipo1.nombre == equipo2.nombre && equipo1.fechaCreacion == equipo2.fechaCreacion;
        }
        public static bool operator != (Equipo equipo1, Equipo equipo2) 
        {
            return !(equipo1 == equipo2);
        }

    }
}
