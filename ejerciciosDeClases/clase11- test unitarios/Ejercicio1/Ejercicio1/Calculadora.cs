using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Calculadora
    {
        public static int add(string numeros)
        {
            string permitidos = ",\n"; 
            string delimitador = (numeros.Split('\n'))[0];
            int suma = 0;
            int numeroAux = 0;
            bool avilitarDelimitador = false;

            foreach (char c in delimitador)
            {
                if (c == '\n')
                {
                    avilitarDelimitador = true;
                    break;
                }
            }
            if (delimitador[0] == '/' && delimitador[1] == '/' && delimitador.Length>2 && avilitarDelimitador)
            {
                for(int i =2;delimitador[i]!='\n';i++)
                {
                    permitidos += delimitador[i];
                }
            }
            string[] arrayNumeros = numeros.Split(permitidos.ToCharArray());

            for(int i = 0; i< arrayNumeros.Length; i++)
            {
                numeroAux = 0;
                int.TryParse(arrayNumeros[i], out numeroAux);
                suma+=numeroAux;
            }
            return suma;
        }
            
    }
}
