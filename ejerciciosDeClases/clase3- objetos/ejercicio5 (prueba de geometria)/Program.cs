using System;
using Geometria;
using System.Text;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Regtangulo nuevoRegtangulo = new Regtangulo(1, 2, 3, 4);

            Console.WriteLine("Perimetro ={0} \n Area={1}", nuevoRegtangulo.GetPerimetro(), nuevoRegtangulo.GetArea());

            Console.WriteLine("Perimetro ={0} \n Area={1}", nuevoRegtangulo.GetPerimetro(), nuevoRegtangulo.GetArea());

            Console.WriteLine(DetallesRegtangulo(nuevoRegtangulo));
        }
        private static string DetallesRegtangulo(Regtangulo regtanguloIngreso)
        {
            StringBuilder detallesRegtangulo = new StringBuilder();

            detallesRegtangulo.AppendFormat("vertice 1 (X,Y)= ({0},{1})", regtanguloIngreso.vertice1.GetX(), regtanguloIngreso.vertice1.GetY()); ;
            detallesRegtangulo.AppendLine();
            detallesRegtangulo.AppendFormat("vertice 2 (X,Y)= ({0},{1})", regtanguloIngreso.vertice2.GetX(), regtanguloIngreso.vertice2.GetY()); ;
            detallesRegtangulo.AppendLine();
            detallesRegtangulo.AppendFormat("vertice 3 (X,Y)= ({0},{1})", regtanguloIngreso.vertice3.GetX(), regtanguloIngreso.vertice3.GetY()); ;
            detallesRegtangulo.AppendLine();
            detallesRegtangulo.AppendFormat("vertice 4 (X,Y)= ({0},{1})", regtanguloIngreso.vertice4.GetX(), regtanguloIngreso.vertice4.GetY()); ;
            detallesRegtangulo.AppendLine();

            detallesRegtangulo.AppendFormat("Area = {0} cm", regtanguloIngreso.GetArea());
            detallesRegtangulo.AppendLine();
            detallesRegtangulo.AppendFormat("Perimetro = {0} cm", regtanguloIngreso.GetPerimetro());
            detallesRegtangulo.AppendLine();

            return detallesRegtangulo.ToString();
        }
    }
}
