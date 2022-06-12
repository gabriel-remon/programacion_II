using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MotoCross :VehiculoDeCarrera
    {
        private short cilindrada;

        public MotoCross(short numero, string escuadra)
            : this(numero, escuadra, 0)
        {
           
        }

        public MotoCross(short numero, string escuadra, short cilindrada)
            : base(numero, escuadra)
        {
            this.cilindrada = cilindrada;
        }
        public short CaballosDeFuerza
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                if (value >= 0)
                    this.cilindrada = value;
            }
        }

        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"cilindrada: {this.cilindrada} cc");

            return sb.ToString();
        }

        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            return (a1.cilindrada == a2.cilindrada) && ((VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2);
        }

        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
    }
}
