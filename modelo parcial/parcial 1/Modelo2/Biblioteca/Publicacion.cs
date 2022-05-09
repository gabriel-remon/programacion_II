
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

        protected abstract bool EsColor { get; }

        public virtual bool HayStock
        {
            get
            {
                if (this.stock != 0 && this.importe > 0 )
                {
                    return true;
                }
                return false;

            }
        }


        public float Importe
        {
            get
            {
                return this.importe;
            }
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if(value > 0)
                {
                    this.stock = value;
                }
                else
                {
                    this.stock = 0;
                }
            }
        }

        public string ObtenerInformacion()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"NOMBRE: {this.ToString()}");
            retorno.AppendLine($"STOCK: {this.Stock}");
            retorno.AppendLine($"PRECIO: {this.Importe}");

            return retorno.ToString();
        }

        public Publicacion(string nombre)
            :this(nombre,0,0)
        {

        }

        public Publicacion(string nombre, int stock)
            :this(nombre,stock,0)
        {

        }

        public Publicacion(string nombre, int stock, float importe)
        {
            this.nombre = nombre;
            this.Stock = stock;
            this.importe = importe;
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
