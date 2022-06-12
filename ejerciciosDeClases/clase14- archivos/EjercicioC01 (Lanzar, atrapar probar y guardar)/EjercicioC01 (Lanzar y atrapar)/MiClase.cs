using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC01__Lanzar_y_atrapar_
{
    public class MiClase
    {
        public MiClase()
        {
            try
            {
                MiClase.DivicionPorCero();
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
        public MiClase(int numero)
        {
            try
            {
                MiClase miClase = new MiClase();
            }
            catch(Exception ex)
            {
                throw new UnaExcepcion("Una excepcion", ex);
            }
        }

        public static int DivicionPorCero()
        {
            
           throw new DivideByZeroException();
        }
    }
}
