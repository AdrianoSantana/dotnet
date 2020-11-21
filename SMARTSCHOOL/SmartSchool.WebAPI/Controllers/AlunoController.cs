using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController: ControllerBase
    {
        public AlunoController()
        {
            
        }

        [HttpGet]
        public IActionResult Get() {
            return Ok("Alunos: Adriano, Santana");
        }
    }
}