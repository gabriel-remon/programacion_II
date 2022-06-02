using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciaPorLocal
        {
            get
            {
                return this.CalcularGanacia(TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanacia(TipoLlamada.Provincial);
            }
        }

        public float GananciaPorTotal
        {
            get
            {
                return this.CalcularGanacia(TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        private float CalcularGanacia(TipoLlamada tipo)
        {
            float ganancia = 0;

            foreach(Llamada unaLlamada in this.listaDeLlamadas)
            {
                switch(tipo)
                {
                    case TipoLlamada.Local:
                        if (unaLlamada is Local)
                            ganancia += unaLlamada.CostoLlamada;
                        break;

                    case TipoLlamada.Provincial:
                        if (unaLlamada is Provincial)
                            ganancia += unaLlamada.CostoLlamada;
                        break;

                    default:
                        ganancia += unaLlamada.CostoLlamada;
                        break;
                }
            }

            return ganancia;
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            :this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Razon social: {this.razonSocial}");
            retorno.AppendLine("Lista de llamadas: ");

            foreach (Llamada unaLLamada in this.listaDeLlamadas)
            {
                retorno.AppendLine(unaLLamada.ToString());
            }

            return retorno.ToString();
        }

        public void OrdenarLlamadas()
        {

            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            if(nuevaLlamada != null)
                this.listaDeLlamadas.Add(nuevaLlamada);
        }

        public static bool operator == (Centralita c, Llamada llamada)
        {
            
                foreach (Llamada unaLlamada in c.listaDeLlamadas)
                {
                    if (unaLlamada == llamada)
                    {
                        return true;
                    }
                }
            

            return false;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }
        public static Centralita operator + (Centralita c, Llamada llamada)
        {
            if (c != llamada)
                c.AgregarLlamada(llamada);

            return c;
        }
    }
}
