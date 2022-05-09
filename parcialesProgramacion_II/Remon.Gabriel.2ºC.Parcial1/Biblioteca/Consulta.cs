using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Consulta
    {

        private DateTime fecha;
        private Paciente paciente;

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }
        }

        public Paciente Paciente
        {
            get
            {
                return paciente;
            }
        }

        public Consulta (DateTime fecha, Paciente paciente)
        {
            this.paciente = paciente;
            this.fecha = fecha;
        }

        public override string ToString()
        {
            return String.Format("{0} se ha atendido a {1}",Fecha, paciente.ToString());
        }
    }
}
