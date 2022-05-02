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
    }

}
