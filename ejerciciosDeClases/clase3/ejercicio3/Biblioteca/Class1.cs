using System;
using System.Text;

namespace Biblioteca
{
    public class Estudiante
    {
        public String apellido;
        public String legajo;
        public String nombre;
        public int notaPrimerParcial;
        public int notaSegundoParcial;
        public Random random = new Random();

        public Estudiante()
        {
            this.random = new Random();
        }

        public Estudiante(string nombreIngreso, string apellidoIngreso, string legajoIngreso)
        {
            this.nombre = nombreIngreso;
            this.apellido = apellidoIngreso;
            this.legajo = legajoIngreso;
        }

        public void SetNotaPrimerParcial(int notaIngreso)
        {
            this.notaPrimerParcial = notaIngreso;
        }

        public void SetNotaSegundoParcial(int notaIngreso)
        {
            this.notaSegundoParcial = notaIngreso;
        }

        private float CalcularPromedio()
        {
            return (float)(notaPrimerParcial + notaSegundoParcial) / 2;
        }

        public float CalcularNotaFinal()
        {
            float retorno;

            if(CalcularPromedio()>=4)
            {
                retorno = this.random.Next(6, 10);
            }
            else
            {
                retorno = -1;
            }

            return retorno;
        }

        public string mostrar()
        {
            StringBuilder textoSalida = new StringBuilder();
            float notaFinal;

            textoSalida.AppendFormat("Nombre: {0}",nombre);
            textoSalida.AppendLine();
            textoSalida.AppendFormat("Apellido: {0}", apellido);
            textoSalida.AppendLine();
            textoSalida.AppendFormat("Legajo: {0}", legajo);
            textoSalida.AppendLine();
            textoSalida.AppendFormat("Nota primer parcial: {0}", notaPrimerParcial);
            textoSalida.AppendLine();
            textoSalida.AppendFormat("Nota segundo parcial: {0}", notaSegundoParcial);
            textoSalida.AppendLine();

            notaFinal = CalcularNotaFinal();
            if(notaFinal != -1)
            {
                textoSalida.AppendFormat("La nota final es: {0:##.00}", notaFinal);
                textoSalida.AppendLine();
            }
            else
            {
                textoSalida.AppendLine("Alumno desaprobado");
            }
            
            return textoSalida.ToString();
        }

    }
}
