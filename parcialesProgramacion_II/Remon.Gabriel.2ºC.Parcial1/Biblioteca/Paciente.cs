using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Paciente: Persona
    {
        public enum ListaDiagnostico
        {
            Curado,
            Gripe,
            Coronavirus
        }

        public ListaDiagnostico diagnostico;

        public ListaDiagnostico Diagnostico
        {
            get
            {
                var random = new Random();
                int numeroRandom= random.Next(2);

                switch(numeroRandom)
                {
                    case 0:
                        return ListaDiagnostico.Curado;
                        
                    case 1:
                        return ListaDiagnostico.Coronavirus;
                      
                    default:
                        return ListaDiagnostico.Gripe;
             
                }
                
            }
            set
            {
                this.diagnostico = value;
            }
        }

        internal override string FichaExtra()
        {
            StringBuilder retono = new StringBuilder();
            
            retono.AppendLine($"RECIDENCIA {barrioRecidencia}");
           // retono.AppendLine(Convert.ToString(diagnostico));
            retono.AppendLine(String.Format("Paciente {0}",diagnostico));

            return retono.ToString();
        }

        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia)
            :base(nombre,apellido,nacimiento,barrioRecidencia)
        {  }
    }
}
