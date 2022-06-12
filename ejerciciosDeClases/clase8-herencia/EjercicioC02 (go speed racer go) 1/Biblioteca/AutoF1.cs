using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AutoF1 :VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                if (value > 0)
                    this.caballosDeFuerza = value;
            }
        }

        public AutoF1(short numero, string escuderia)
            :this(numero,escuderia,1)
        { }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            :base(numero,escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        public override string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(base.MostrarDatos());
            retorno.AppendLine($"Caballos de fuerza: {this.caballosDeFuerza}");

            return retorno.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.Escuderia==a2.Escuderia)&&(a1.Numero==a2.Numero)&&(a1.caballosDeFuerza==a2.caballosDeFuerza);
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

    }
}
