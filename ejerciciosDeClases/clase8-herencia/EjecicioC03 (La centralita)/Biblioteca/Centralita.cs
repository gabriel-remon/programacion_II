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
                return CalcularGanacia(TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return CalcularGanacia(TipoLlamada.Provincial);
            }
        }

        public float GananciaPorTotal
        {
            get
            {
                return CalcularGanacia(TipoLlamada.Todas);
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
                            ganancia += ((Local)unaLlamada).CostoLlamada;
                        break;

                    case TipoLlamada.Provincial:
                        if (unaLlamada is Provincial)
                            ganancia += ((Provincial)unaLlamada).CostoLlamada;
                        break;

                    default:
                        if (unaLlamada is Provincial)
                            ganancia += ((Provincial)unaLlamada).CostoLlamada;
                        if (unaLlamada is Local)
                            ganancia += ((Local)unaLlamada).CostoLlamada;
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

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Razon social: {this.razonSocial}");
            retorno.AppendLine("Lista de llamadas: ");

            foreach (Llamada unaLLamada in this.listaDeLlamadas)
            {
                retorno.AppendLine(unaLLamada.Mostrar());
            }

            return retorno.ToString();
        }

        public void OrdenarLlamadas()
        {

        }
    }
}
