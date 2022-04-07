using System;
using System.Text;

namespace Biblioteca
{
    public class Cuenta
    {

        public string titular;
        public decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public decimal GetCantidad()
        {
            return this.cantidad;
        }

        public string mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            string retornoAux;

            retorno.AppendFormat("Titutar: {0}\n",this.GetTitular()) ;
            retorno.AppendFormat("Dinero en cuenta: {0}",GetCantidad()); 
            retornoAux = retorno.ToString();

            return retornoAux;
        }

        public void IngresarMonto(decimal ingresoMonto)
        { 
            if(ingresoMonto > 0)
            {
                this.cantidad = this.cantidad + ingresoMonto;
            }
        }

        public void RetiroMonto(decimal retiroMonto)
        {
            this.cantidad = this.cantidad - retiroMonto;
        }
    }
}
