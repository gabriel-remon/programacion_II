using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC01__Lanzar_y_atrapar_
{
    public class MiExcepcion :Exception
    {
        public MiExcepcion(string txtIngreso)
            : this(txtIngreso,null)
        {

        }
        public MiExcepcion(string txtIngreso, Exception ex)
            : base(txtIngreso, ex)
        {

        }
    }
}
