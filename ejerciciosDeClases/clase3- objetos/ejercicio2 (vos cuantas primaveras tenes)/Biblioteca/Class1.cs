using System;
using System.Text;

namespace Biblioteca
{
    public class persona
    {
        public string nombre;
        public DateTime fechaNacimiento = new DateTime();
        public int Dni;
        
        public persona()
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.Dni = Dni;
        }

        public void SetNombre(string nombreINgreso)
        {
            this.nombre = nombreINgreso;
        }

        public void SetFecha(int anio, int mes, int dia)
        {
            this.fechaNacimiento = new DateTime(anio, mes, dia);
        }

        public void SetDni(int DniIngreso)
        {
            this.Dni = DniIngreso;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public DateTime GetFechaNacimiento()
        {
            return fechaNacimiento;
        }

        public int GetDni()
        {
            return Dni;
        }
        
        private int CalcularEdad(DateTime edadActual)
        {

           return ((DateTime.Today).Subtract(edadActual).Days)/365;
        }
        
        public string mostrar()
        {
            StringBuilder textoSalida = new StringBuilder();

            textoSalida.AppendFormat("nombre: {0}", nombre);
            textoSalida.AppendLine();
            textoSalida.AppendFormat("Edad: {0}",CalcularEdad(fechaNacimiento));
            textoSalida.AppendLine();
            textoSalida.AppendFormat("DNI: {0}",Dni); ;

            return textoSalida.ToString();
        }

        public string EsMayorDeEdad()
        {
            string retorno;

            if(CalcularEdad(fechaNacimiento) >= 18)
            {
                retorno = "Es mayor de edad";
            }
            else
            {
                retorno = "Es menor de edad";
            }

            return retorno;
        }
    }
}
