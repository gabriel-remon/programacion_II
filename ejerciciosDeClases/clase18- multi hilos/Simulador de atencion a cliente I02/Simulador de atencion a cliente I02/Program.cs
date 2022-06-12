using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Biblioteca;

namespace Simulador_de_atencion_a_cliente_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Task> subTareas;

            DelegadoCliente delegadoCliente = (caja, nombre) =>
            {
                Console.WriteLine($"{DateTime.Now.ToString("T")} - " +
                                   $"Hilo {Task.CurrentId} -" +
                                   $"{caja.NombreCaja} -" +
                                   $"Atendio a {nombre} ." +
                                   $" quedan {caja.CantidadDeClientesALaEspera} clientes en esta caja");

            };

            Caja caja1 = new Caja("Caja 1", delegadoCliente);
            Caja caja2 = new Caja("Caja 2", delegadoCliente);
            List<Caja> cajas = new List<Caja> {caja2,caja1};
            Negocio negocio = new Negocio(cajas);

            Console.WriteLine("Asignando cajas...");

            //negocio.ComenzarAtencion();

            subTareas = negocio.ComenzarAtencion();
            Task.WaitAll(subTareas.ToArray());
            
        }
    }
}
