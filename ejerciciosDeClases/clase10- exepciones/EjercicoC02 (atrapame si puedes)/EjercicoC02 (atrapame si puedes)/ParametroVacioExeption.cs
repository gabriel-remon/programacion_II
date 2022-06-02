using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicoC02__atrapame_si_puedes_
{
    public class ParametroVacioExeption : Exception
    {

        public ParametroVacioExeption(string txtIngreso)
            :this(txtIngreso,null)
        {

        }

        public ParametroVacioExeption(string txtIngreso, Exception ex) 
            :base(txtIngreso,ex)
        {

        }
    }
}
