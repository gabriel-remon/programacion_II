using System;
using System.Text;

namespace Biblioteca
{
    public class Producto
    {
        string codidoDeBarras;
        string marca;
        float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.codidoDeBarras = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat($"Marca: {p.GetMarca()}");
            retorno.AppendLine();
            retorno.AppendFormat($"Precio: ${p.GetPrecio()}");
            retorno.AppendLine();
            retorno.AppendFormat($"Codigo de barras: {(string) p}");
            retorno.AppendLine();

            return retorno.ToString();
        }

        public static explicit operator string (Producto p)
        {
            return p.codidoDeBarras;
        }

        public static bool operator == (Producto p1, Producto p2)
        {
            return (p1.codidoDeBarras == p2.codidoDeBarras) && (p1.marca == p2.marca);
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p1, string marca)
        {
            return p1.marca == marca;
        }

        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1 == marca);
        }
    }

    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion): this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto [] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder retorno = new StringBuilder();
            Producto productoAux;
  
            retorno.AppendLine("Los productos del estante son:");

            for(int i=0; i<e.productos.Length  ; i++)
            {

                productoAux = e.productos[i];
                retorno.AppendLin);
            }

            return retorno.ToString();
        }
    }
}
