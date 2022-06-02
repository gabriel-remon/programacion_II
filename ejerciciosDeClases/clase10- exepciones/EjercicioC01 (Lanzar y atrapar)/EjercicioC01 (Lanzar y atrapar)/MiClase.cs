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
                MiClase.DivicionPorCero(34);
            }
            catch (DivideByZeroException ex)
            {
                MiClase miClase = new MiClase(ex);
            }
        }
        public MiClase(Exception excepcion)
        {
            try 
            {
                MiClase.DivicionPorCero(34);
            }
            catch 
            {

            }
        }

        public static int DivicionPorCero(int numero)
        {
            
            return numero / 0;
        }
    }
}
