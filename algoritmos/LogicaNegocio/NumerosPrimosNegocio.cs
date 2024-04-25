using algoritmos.Entidades;
using System.Diagnostics.Metrics;
using System;

namespace algoritmos.LogicaNegocio
{
    public class NumerosPrimosNegocio
    {
        /// <summary>
        /// algoritmo 50 primeros numeros primos
        /// </summary>
        /// <returns></returns>
        public List<string> Primeros50NumerosPrimos()
        {
            List<string> listadoRespuesta = new List<string>();

            int count = 0;
            int numeroInicio = 2;
            while (count < 50)
            {
                if (EsNumeroPrimo(numeroInicio))
                {
                    listadoRespuesta.Add($"número primo {count + 1}: {numeroInicio}");
                    count++;
                }
                numeroInicio++;
            }

            return listadoRespuesta;
        }

        /// <summary>
        /// valida si numero es primo
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        bool EsNumeroPrimo(int numero)
        {
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }
    }
}
