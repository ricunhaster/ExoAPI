using ExoAPI.WebAPI.Models;
using ExoAPI.WebAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExoAPI.WebAPI.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class ExoController : ControllerBase
    {
        private readonly ExoRepository _exoRepository;
        public ExoController(ExoRepository exoRepository)
        {
            _exoRepository = exoRepository;
        }


        [HttpGet]

        public IActionResult Listar()
        {
            try
            {
                return Ok(_exoRepository.Listar());

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            try
            {
                ExoProjeto projetoBuscado = _exoRepository.BuscarPorId(id);

                if (projetoBuscado == null)
                {
                    return NotFound();
                }

                return Ok(projetoBuscado);
            }

            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        //[Authorize(Roles = "1")]

        [HttpPost]

        public IActionResult Cadastrar(ExoProjeto projeto)
        {
            try
            {
                _exoRepository.Cadastrar(projeto);

                return StatusCode(201);

            }

            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        [HttpPut("{id}")]

        public IActionResult Cadastrar(int id, ExoProjeto projeto)
        {

            try
            {
                _exoRepository.Atualizar(id, projeto);

                return StatusCode(204);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        //[Authorize(Roles = "1")
        [HttpDelete("{id}")]

        public IActionResult Deletar(int id)
        {
            try
            {
                _exoRepository.Deletar(id);

                return Ok("Projeto deletado");

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
