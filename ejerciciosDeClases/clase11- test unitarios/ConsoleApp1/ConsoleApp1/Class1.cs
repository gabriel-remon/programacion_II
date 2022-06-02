using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class metodosExtencion
    {
        /// <summary>
        /// Extiente el objeto int (Int32) y agrega el metodo FizzBuzz como un metodo estatico de la 
        /// clase el cual se invocara como numero.FIzzBuzz
        /// </summary>
        /// <param name="ingreso"></param>
        /// <returns></returns>
        public static string FizzBuzz(this int ingreso)
        {
            string retorno = string.Empty;

            if (ingreso % 3 == 0)
                retorno += "Fizz";

            if (ingreso % 5 == 0)
                retorno += "Buzz";

            if (retorno == string.Empty)
                retorno = ingreso.ToString();

            return retorno;
        }
    }
}
