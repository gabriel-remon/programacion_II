using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jardin
    {
        public enum Tipo
        {
            Terrozo,
            Arenozo
        }

        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo Suelo;

        public Tipo TipoSuelo
        {
            set
            {
                Jardin.Suelo = value;
            }
        }

       private int EspacioOcupado()
       {
            int retorno = 0;

            foreach(Planta UnaPLanta in plantas)
            {
                retorno += UnaPLanta.Tamanio;
            }

            return retorno;
       }

        private int EspacioOcupado(Planta planta)
        {
            return this.EspacioOcupado() + planta.Tamanio;
        }


        static Jardin()
        {
            Jardin.Suelo = Jardin.Tipo.Terrozo;
        }

        private Jardin()
        {
            this.plantas = new List<Planta>();
        }

        public Jardin(int espacioTotal)
            :this()
        {
            this.espacioTotal = espacioTotal;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Composicion del jardin: {Suelo}");
            retorno.AppendLine($"Espacio ocupado {this.EspacioOcupado()} de {this.espacioTotal}");
            retorno.AppendLine("Lista De plantas\n");
            foreach(Planta unaPlanta in this.plantas)
            {
                retorno.AppendLine(unaPlanta.ResumenDeDatos());
            }

            return retorno.ToString();
        }

        public static bool operator + (Jardin jardin, Planta planta)
        {
            if(jardin.espacioTotal >= jardin.EspacioOcupado(planta))
            {
                jardin.plantas.Add(planta);
                return true;
            }

            return false;
        }
    }
}
