using algoritmos.Entidades;

namespace algoritmos.LogicaNegocio
{
    public class CadenaOrdenInversoNegocio
    {
        /// <summary>
        /// algoritmo InvertirCadenaTexto
        /// </summary>
        /// <returns></returns>
        public string InvertirCadenaTexto(string cadenaOriginal)
        {
            string[] arrayPalabrasSeparadas = cadenaOriginal.Split(' ');

            string CadenaInvertida = "";
            for (int i = arrayPalabrasSeparadas.Length - 1; i >= 0; i--)
            {
                CadenaInvertida += arrayPalabrasSeparadas[i];
                if (i > 0)
                    CadenaInvertida += " ";
            }

            return CadenaInvertida;
        }
    }
}
