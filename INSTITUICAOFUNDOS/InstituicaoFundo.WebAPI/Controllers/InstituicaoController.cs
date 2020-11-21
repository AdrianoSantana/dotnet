using Microsoft.AspNetCore.Mvc;

namespace InstituicaoFundo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstituicaoController: ControllerBase
    {
        public InstituicaoController()
        {
            
        }
        [HttpGet]

        public IActionResult Get()
        {
            return Ok("Instituicao1, Instituicao2, Instituicao3");
        }
    }
}