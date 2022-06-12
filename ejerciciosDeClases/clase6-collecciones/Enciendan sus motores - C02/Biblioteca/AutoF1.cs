using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuadra;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuadra)
        {
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
            this.numero = numero;
            this.escuadra = escuadra;
        }

        public bool EnCampotencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia=value;
            }
        }

        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                if(value>=0 && value <=100)
                    this.cantidadCombustible=value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.VueltasRestantes;
            }
            set
            {
                if(value >=0)
                    this.VueltasRestantes=value;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }

        public static bool  operator == (AutoF1 a1, AutoF1 a2)
        {
            return (a1.numero == a2.numero) && (a1.escuadra == a2.escuadra);
        }

        public static bool operator != (AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

    }
}
