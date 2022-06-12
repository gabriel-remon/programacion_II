using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Biblioteca
{

    public delegate void DelegadoCliente(Caja caja, string nombre);
    public class Caja
    {
        private static Random random;
        private Queue<string> clientesALaEspera = new Queue<string>();
        private string nombreCaja;
        private DelegadoCliente delegadoClienteAtendido;

        static Caja()
        {
            random = new Random();
        }

        public Caja(string nombrerCaja,DelegadoCliente delegadoClienteAtendido)
        {
            this.clientesALaEspera = new Queue<string>();
            this.nombreCaja = nombrerCaja;
            this.delegadoClienteAtendido = delegadoClienteAtendido;
        }

        public int CantidadDeClientesALaEspera
        {
            get
            {
                return clientesALaEspera.Count;
            }
        }

        public string NombreCaja
        {
            get
            {
                return this.nombreCaja;
            }
        }

        internal void AgregarCliente(string cliente)
        {
            clientesALaEspera.Enqueue(cliente);
        }

        internal Task IniciarAtencion()
        {
            return Task.Run(() => 
            {
                while(true)
                {
                    if(clientesALaEspera.Any<string>())
                    {
                        delegadoClienteAtendido(this, this.clientesALaEspera.Dequeue());
                        Thread.Sleep(random.Next(1, 5) * 1000);
                    }
                }
            });
        }

        

    }
}
