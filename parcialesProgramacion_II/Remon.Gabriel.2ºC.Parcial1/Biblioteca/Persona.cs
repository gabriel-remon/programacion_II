using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioRecidencia;
        protected DateTime nacimiento;
        protected string nombre;

        public int Edad
        {
            get
            {
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year;
            }
        }

        public string NombreCompleto
        {
            get
            {
                return this.ToString();
            }
        }

        internal abstract string FichaExtra();
          

        public static string FichaPersona(Persona p)
        {
            StringBuilder retono = new StringBuilder();
            if (p != null)
            {
                retono.AppendLine(p.ToString());
                retono.AppendLine($"EDAD {p.Edad}");
                retono.AppendLine(p.FichaExtra());
            }
            return retono.ToString();
        }

        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }

        public Persona(string nombre, string apellido, DateTime nacimiento,string barrioRecidencia)
            : this(nombre, apellido,nacimiento)
            
        {
            this.barrioRecidencia = barrioRecidencia;
        }

        public override string ToString()
        {
            return string.Format("{1}, {0}",nombre,apellido);
        }
    }
}
