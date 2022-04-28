using System;
namespace Biblioteca
{
    public class PuestoAccion
    {

        private static int numeroActual;
        private Puesto puesto;

        public int NumeroActual
        {
            set
            {
                numeroActual = value;
            }
            get
            {
                numeroActual++;
                return numeroActual;
            }
        }

        public bool Atender(Cliente cli)
        {
            System.Threading.Thread.Sleep(1000);
            return true;
        }


        private PuestoAccion():this(Puesto.caja1)
        {
            numeroActual = 0;

        }
        public PuestoAccion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public enum Puesto
        {
            caja1,
            caja2
        }
    }
}
