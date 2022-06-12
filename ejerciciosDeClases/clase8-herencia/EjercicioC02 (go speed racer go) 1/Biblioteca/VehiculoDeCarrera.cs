using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                if(value>=0 && value <=100)
                this.cantidadCombustible = value;
            }
        }

        public bool EnCompetencia 
        { 
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }

        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }

        public short Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        public virtual string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Cantidad de combustible: {this.cantidadCombustible}");
            retorno.AppendLine(string.Format("En competencia: {0}",this.enCompetencia?"SI":"NO"));
            retorno.AppendLine($"Escuderia: {this.escuderia}");
            retorno.AppendLine($"Numero del vehiculo: {this.Numero}");
            retorno.AppendLine($"Vueltas restantes: {this.vueltasRestantes}");

            return retorno.ToString();
        }

        public VehiculoDeCarrera (short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.vueltasRestantes = 0;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
        }
    }
}
