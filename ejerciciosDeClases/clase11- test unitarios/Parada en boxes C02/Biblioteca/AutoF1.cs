using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AutoF1:VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public AutoF1(short numero, string escuadra)
            :this(numero,escuadra,0)
        {
           
        }

        public AutoF1(short numero, string escuadra, short caballosDeFuerza)
            : base(numero, escuadra)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }
        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                if(value >=0)
                    this.caballosDeFuerza = value;
            }
        }

        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Caballos de fuerza= {this.caballosDeFuerza}");

            return sb.ToString();
        }

        public static bool  operator == (AutoF1 a1, AutoF1 a2)
        {
            return (a1.caballosDeFuerza == a2.caballosDeFuerza) && ((VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2);
        }

        public static bool operator != (AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

    }
}
