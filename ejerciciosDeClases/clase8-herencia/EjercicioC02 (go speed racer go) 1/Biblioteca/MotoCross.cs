using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public short Cilindrada 
        { 
            get 
            {
                return this.cilindrada;
            }
            set 
            { 
                if(value>0)
                    this.cilindrada = value;
            } 
        }

        public override string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(base.MostrarDatos());
            retorno.AppendLine($"Cilindradas: {this.cilindrada}");

            return retorno.ToString();
        }

        public MotoCross (short numero, string escuderia)
            :this(numero,escuderia,1)
        { }

        public MotoCross (short numero, string escuderia, short cilindrada)
            :base(numero,escuderia)
        {
            this.cilindrada = cilindrada;
        }

        public static bool operator == (MotoCross m1, MotoCross m2)
        {
            return (m1.Escuderia == m2.Escuderia) && (m1.Numero == m2.Numero) && (m1.cilindrada == m2.cilindrada);
        }
        public static bool operator != (MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }
    }
}
