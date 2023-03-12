using Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {


        private readonly ILogger<UsuariosController> _logger;
        private readonly IUserUseCase _userUseCase;

        public UsuariosController(ILogger<UsuariosController> logger, IUserUseCase userUseCase)
        {
            _logger = logger;
            _userUseCase = userUseCase;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userUseCase.GetUsers());
        }


    }
}