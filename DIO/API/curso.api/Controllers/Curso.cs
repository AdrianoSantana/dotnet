using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using curso.api.Models.Cursos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace curso.api.Controllers
{
    [Route("api/v1/curso")]
    [ApiController]
    [Authorize]
    public class Cursos: ControllerBase
    {
        /// <summary>
        ///     Este serviço permite Cadastrar cursos 
        /// </summary>
        /// <param name="loginViewModelInput"></param>
        /// <returns> Um objeto de com Nome e Descrição </returns>
        [HttpPost]
        public async Task<IActionResult> Post(CursoViewModelInput cursoViewModelInput)
        {
            var codigoUsuario = int.Parse(User.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value);
            return Created("Criado!", cursoViewModelInput);
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            //var codigoUsuario = int.Parse(User.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value);
            var cursos = new List<CursoViewModelOutput>();

            cursos.Add(
                new CursoViewModelOutput() {
                    Login = "1",
                    Descricao = "Curso qualquer",
                    Nome = "Curso 1"
                }
            );
            return Ok(cursos);
        }
    }
}