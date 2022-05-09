using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;

        internal override string FichaExtra()
        {
            StringBuilder retono = new StringBuilder();

            retono.AppendLine(String.Format("¿Finalizo residencia? {0}",esResidente?"SI":"NO"));
            retono.AppendLine("ATENCIONES");
            foreach(Consulta unaConsulta in consultas)
            {
                 retono.AppendLine(Persona.FichaPersona(unaConsulta.Paciente));
            }

            return retono.ToString();
        }

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esResidente)
            :base(nombre,apellido,nacimiento)
        {
            this.consultas = new List<Consulta>();
            this.esResidente = esResidente;
        }

        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            Consulta consulta = new Consulta(DateTime.Now, paciente);

            doctor.consultas.Add(consulta);

            return consulta;
            
        }


    }
}
