using System;

namespace Biblioteca
{
    public class Conductores
    {
        string nombreConductor;
        int[] kmDiarios;

        public Conductores()
        {
            this.nombreConductor = "";
            this.kmDiarios = new int[7];
        }

        public void SetNombreConductor(string nombreIngreso)
        {
            this.nombreConductor = nombreIngreso;
        }

        public void SetKmDiarios(int diaDeLaSemana, int cantidadKm)
        {
            this.kmDiarios[diaDeLaSemana] = cantidadKm;
        }

        public string GetNombre()
        {
            return this.nombreConductor;
        }

        /// <summary>
        /// retorna la cantidad de km que hizo en un dia indicado
        /// </summary>
        /// <param name="diaDeLaSemana" dia de la semana indicado></param>
        /// <returns></returns>
        public int GetKmUnDia(int diaDeLaSemana)
        {
            return this.kmDiarios[diaDeLaSemana];
        }

        /// <summary>
        /// Retorna el dia que hizo mas cantidad de km
        /// </summary>
        /// <returns></returns>
        public int GetDiaMeyorKm()
        {
            int mayor = this.kmDiarios[0];
            int retorno = 0;

            for(int i = 1 ; i<6; i++ )
            {
                if (this.kmDiarios[i] > mayor)
                {
                    mayor = this.kmDiarios[i];
                    retorno = i;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Retorna la cantidad total de km que hizo un conductor
        /// </summary>
        /// <returns></returns>
        public int GetSumaKm()
        {
            int retorno = 0;

            for(int i = 0; i<6 ; i++)
            {
                retorno = retorno + this.kmDiarios[i];
            }

            return retorno;
        }

    }
}
