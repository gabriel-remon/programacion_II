using System;
using System.Collections.Generic;
using System.Text;

namespace Centralita
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(TipoLLamada.Local);
            }
        }

        public float GananciasPorProvincia
        {
            get
            {
                return this.CalcularGanancia(TipoLLamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLLamada.Todas);
            }
        }

        public List<Llamada> Lamadas
        {
            get
            {
                return listaDeLlamadas;
            }
        }

        private float CalcularGanancia(TipoLLamada tipo)
        {
            float gananciaLocal = 0;
            float gananciProvincia = 0;
            float retono = 0;


            foreach (Llamada unaLlamada in listaDeLlamadas)
            {
                if(unaLlamada is Local)
                {
                    gananciaLocal += ((Local)unaLlamada).CostoLlamada;
                }
                if(unaLlamada is Provincia)
                {
                    gananciProvincia += ((Provincia)unaLlamada).CostoLlamada;
                }
            }

            switch (tipo)
            {
                case TipoLLamada.Local:
                    retono = gananciaLocal;
                    break;

                case TipoLLamada.Provincial:
                    retono = gananciProvincia;
                    break;

                default:
                    retono = gananciProvincia + gananciaLocal;
                    break;

            }

            return retono;

        }

        private Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this ()
        {
            this.razonSocial = nombreEmpresa;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(razonSocial);

            foreach(Llamada unaLlamada in listaDeLlamadas)
            {
                retorno.AppendLine(unaLlamada.Mostrar());
            }

            return retorno.ToString();
        }

        public void OrdenarLlamadas()
        {

        }

    }
}
