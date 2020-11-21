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
            return Ok("Fundo 1, Fundo 2");
        }
    }
}