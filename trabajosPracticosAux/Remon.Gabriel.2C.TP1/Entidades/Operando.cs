using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        private string Numero
        {
            set
            {
                numero= ValidarOperando(value);
            }
        }

        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor invalido";
            double decimalAux = 0;

            if(EsBinario(binario))
            {
                for(int i = binario.Length; i >=0 ; i--)
                {
                    if(binario.Substring(i) == "1")
                    {
                        decimalAux = decimalAux + Math.Pow(2, i);
                    }
                }
                retorno = Convert.ToString(decimalAux);
            }

            return  retorno;
        }

        public string DecimalBinario(double numero)
        {
            string retorno = String.Empty;

            numero = Math.Abs(numero);

            do
            {
                if((numero % 2 )== 0)
                {
                    retorno = "0" + retorno;
                }
                else
                {
                    retorno = "1" + retorno;
                    numero--;
                }
                numero = numero / 2;

            } while (numero != 0);

            return retorno;
        }

        public string DecimalBinario(string numero)
        {
            string retorno = string.Empty;

            double numeroAux;

            if(double.TryParse(numero,out numeroAux))
            {
                retorno = DecimalBinario(numeroAux); 
            }

            return retorno;
        }

        private bool EsBinario(string binario)
        {
            bool retorno = false;

            for (int i = 0 ; i<=binario.Length ; i++ )
            {
                if(binario.Substring(i) != "1" && binario.Substring(i) != "0" )
                {
                    break; 
                }

                retorno = true;
            }

            return retorno;
        }

        public Operando()
        {
            this.numero =  0 ;
        }

        public Operando( double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero): this()
        {
            double.TryParse(strNumero, out this.numero);
        }

        public static double operator + (Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator - (Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator * (Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator / (Operando n1, Operando n2)
        {
            double retorno = double.MinValue;

            if(n2.numero != 0)
            {
                retorno = n1.numero / n2.numero;
            }

            return retorno;
        }

        private double ValidarOperando(string strNumero)
        {
            double retorno = 0;

            double.TryParse(strNumero, out retorno);

            return retorno;
        }

    }
}
