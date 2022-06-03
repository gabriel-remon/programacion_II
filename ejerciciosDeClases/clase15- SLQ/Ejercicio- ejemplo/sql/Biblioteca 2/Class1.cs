using System;
using System.Data.SqlClient;

namespace Biblioteca_2
{
    public class coneccionServidor
    {
        public void guardar()
        {
            string rutaConeccion = @"Server=.;Database=Clientes;Trusted_Connection=true";
            SqlConnection coneccion = new SqlConnection(rutaConeccion);


            coneccion.Open();

            string comando = "INSERT INTO Clientes(nombre, direccion) VALUES (@nombre, @direccion)";

            SqlCommand sqlCommand = new SqlCommand(comando, coneccion);
            
        }
    }
}
