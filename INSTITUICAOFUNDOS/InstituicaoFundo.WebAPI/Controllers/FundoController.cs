using Microsoft.AspNetCore.Mvc;

namespace InstituicaoFundo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FundoController: ControllerBase
    {
        public FundoController()
        {
            
        }
        [HttpGet]

        public IActionResult Get()
        {
            return Ok("Fundo1, Fundo2, Fundo3");
        }
    }
}