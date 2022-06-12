using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Contabilidad <T,U>
        where U : Documento,new()
        where T : Documento
    {
        
        List<T> egresos;
        List<U> ingresos;
        
        public Contabilidad()
        {
            egresos = new List<T>();    
            ingresos = new List<U>();
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, T egreso )
        {
            if (c is not null && egreso is not null)
                c.egresos.Add(egreso);
            return c;
        }
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            if(c is not null && ingreso is not null )
                c.ingresos.Add( ingreso );
            return c;
        }

        public string mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lsita de Egresos:");
            foreach (T e in egresos)
            {
                sb.AppendLine($"{typeof(T)} N° {e.NumeroDocumento}");
            }
            sb.AppendLine("Lista de Ingresos:");
            foreach(U u in ingresos)
            {
                sb.AppendLine($"{typeof(U)} N° {u.NumeroDocumento}");
            }

            return sb.ToString();
        }

    }
}
