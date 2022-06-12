using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Negocio
    {
        private PuestoAccion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                
               clientes.Enqueue(value);
                //esto hay que corregirlo
            }
        }
        public int ClientesPendientes
        {
            get
            {
                return clientes.Count;
            }
        }

        private Negocio()
        {
            this.caja = new PuestoAccion(PuestoAccion.Puesto.caja1);
            this.clientes = new Queue<Cliente>();
        }

        public Negocio (string nombre):this()
        {
            this.nombre = nombre;
        }


        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;

            if(n != c)
            {
                n.Cliente = c;
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ~(Negocio n)
        {
            bool retorno = false;
            

            if(n.clientes.Count > 0 )
            {
                retorno = n.caja.Atender(n.Cliente);
            }

            return retorno;
        }


        public static bool operator ==(Negocio n, Cliente c)
        {
            bool hayCliente = false;

            foreach(Cliente clienteAux in n.clientes)
            {
                if(clienteAux==c)
                {
                    hayCliente = true;
                    break;
                }
            }

            return  hayCliente;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n==c);
        }


    }
}
