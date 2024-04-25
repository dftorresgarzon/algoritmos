using algoritmos.Entidades;
using algoritmos.LogicaNegocio;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace algoritmos.Controllers
{
    [EnableCors("MyCorsPolicy")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AlgoritmosController : Controller
    {
        #region inyeccion de dependencias

        /// <summary>
        /// Instancia BingoNegocio
        /// </summary>
        private readonly BingoNegocio _bingoNegocio;

        /// <summary>
        /// Instancia NumerosPrimosNegocio
        /// </summary>
        private readonly NumerosPrimosNegocio _numerosPrimosNegocio;

        /// <summary>
        /// Instancia CadenaOrdenInversoNegocio
        /// </summary>
        private readonly CadenaOrdenInversoNegocio _cadenaOrdenInversoNegocio;

        /// <summary>
        /// Constructor
        /// </summary>
        public AlgoritmosController(BingoNegocio bingoNegocio, NumerosPrimosNegocio numerosPrimosNegocio, CadenaOrdenInversoNegocio cadenaOrdenInversoNegocio)
        {
            this._bingoNegocio = bingoNegocio;
            this._numerosPrimosNegocio = numerosPrimosNegocio;
            this._cadenaOrdenInversoNegocio = cadenaOrdenInversoNegocio;
        }

        #endregion inyeccion de dependencias

        [HttpPost]
        public ActionResult<List<Bingo>> Bingo()
        {
            List<Bingo> listado = _bingoNegocio.BingoAlgoritmo();
            return Ok(listado);
        }

        [HttpPost]
        public ActionResult<List<string>> NumerosPrimos()
        {
            List<string> listado = _numerosPrimosNegocio.Primeros50NumerosPrimos();
            return Ok(listado);
        }

        [HttpPost]
        public ActionResult<string> CadenaOrdenInverso(string cadena)
        {
            string cadenaInvertida = _cadenaOrdenInversoNegocio.InvertirCadenaTexto(cadena);
            return Ok(cadenaInvertida);
        }
    }
}
