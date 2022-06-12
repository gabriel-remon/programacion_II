using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC01__Lanzar_y_atrapar_
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion(string txtIngreso)
             : this(txtIngreso,null)
        {

        }
        public UnaExcepcion(string txtIngreso, Exception ex)
            : base(txtIngreso,ex)
        {

        }
    }
}
