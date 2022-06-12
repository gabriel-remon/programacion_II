using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NameGenerator;
using NameGenerator.Generators;
using System.Collections.Concurrent;
using System.Threading;


namespace Biblioteca
{
    public class Negocio
    {
        Task t;
        private static RealNameGenerator nombreGenerado;
        private ConcurrentQueue<string> clientes;
        List<Caja> cajas;

        static Negocio()
        {
            nombreGenerado = new RealNameGenerator();
        }

        public Negocio(List<Caja> cajas)
        {
            this.clientes = new ConcurrentQueue<string>();
            this.cajas= cajas;
        }

        public List<Task> ComenzarAtencion()
        {
            List<Task> subTareas = new List<Task> ();

            foreach(Caja unaCaja in cajas)
            {
                subTareas.Add(unaCaja.IniciarAtencion());
            }

            subTareas.Add(Task.Run(() =>
            {
                while(true)
                {
                    clientes.Enqueue(nombreGenerado.Generate());
                    Thread.Sleep(1000);
                }
            }));
            subTareas.Add(Task.Run(() =>
            {
                while (true)
                {
                    Caja cajaAux;
                    string clienteAux;
                    cajaAux = cajas.OrderBy(caja => caja.CantidadDeClientesALaEspera).First();
                    if (clientes.TryDequeue(out clienteAux))
                        cajaAux.AgregarCliente(clienteAux);
                    //clientes.TryDequeue;
                }
            }));


            return subTareas;
        }

    }
}
