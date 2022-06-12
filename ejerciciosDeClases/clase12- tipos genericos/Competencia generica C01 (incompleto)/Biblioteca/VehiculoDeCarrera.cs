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
        private string escuadra;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuadra)
        {
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
            this.numero = numero;
            this.escuadra = escuadra;
        }

        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                if (value >= 0 && value <= 100)
                    this.cantidadCombustible = value;
            }
        }
        public bool EnCampotencia
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

        public string Escuadra
        {
            get
            {
                return this.escuadra;
            }
            set
            {
                this.escuadra = value;
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
                if (value >= 0)
                    this.vueltasRestantes = value;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Escuadra: {this.escuadra}");
            sb.AppendLine($"Numero del Vehiculo: {this.numero}");
            sb.AppendLine($"cantidad de Combustible: {this.cantidadCombustible}");
            sb.AppendLine($"Vueltas restantes: {this.vueltasRestantes}");
            sb.AppendFormat("En competencia: {0}", this.enCompetencia ? "Si" : "NO");

            return sb.ToString();
        }

        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return (v1.numero == v2.numero) && (v1.escuadra == v2.escuadra);
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }
    }
}
