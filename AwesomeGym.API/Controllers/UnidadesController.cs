using AwesomeGym.Application.InputModels;
using AwesomeGym.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AwesomeGym.API.Controllers
{
    [Route("api/unidades")]
    public class UnidadesController : ControllerBase
    {
        private readonly IUnidadeService _unidadeService;
        public UnidadesController(IUnidadeService unidadeService)
        {
            _unidadeService = unidadeService;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            var unidades = await _unidadeService.ObterTodos();

            return Ok(unidades);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]UnidadeInputModel unidadeInputModel)
        {
            var id = await _unidadeService.Adicionar(unidadeInputModel);

            return CreatedAtAction(nameof(ObterPorId), new { id = id }, unidadeInputModel);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            var unidade = await _unidadeService.ObterPorId(id);

            if (unidade == null)
            {
                return NotFound();
            }

            return Ok(unidade);
        }
    }
}
