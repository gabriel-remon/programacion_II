using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC01__Lanzar_y_atrapar_
{
    public class OtraClase
    {
        public OtraClase()
        {
            try
            {
                MiClase miClase = new MiClase();
            }
            catch(Exception ex)
            {
                throw new MiExcepcion("Mi excepcion", ex);
            }
        }

    }
}
