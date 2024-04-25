using algoritmos.Entidades;

namespace algoritmos.LogicaNegocio
{
    public class BingoNegocio
    {
        /// <summary>
        /// algoritmo bingo
        /// </summary>
        /// <returns></returns>
        public List<Bingo> BingoAlgoritmo()
        {
            List<Bingo> listadoRespuesta = new List<Bingo>();

            for (int num = 1; num <= 100; num++)
            {
                string label = "";

                if (num % 3 == 0)
                    label += "Bin";

                if (num % 5 == 0)
                    label += "Go";

                if (label == "")
                    label = "no cumple";

                Bingo resgistro = new Bingo()
                {
                    Numero = num,
                    Resultado = label,
                };

                listadoRespuesta.Add(resgistro);
            }
            return listadoRespuesta;
        }
    }
}
