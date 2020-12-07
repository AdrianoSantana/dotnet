using System.Linq;
using curso.api.Filters;
using curso.api.Models.Usuarios;
using curso.api.Models.Validations;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace curso.api.Controllers
{
    [Route("api/v1/usuario")]
    [ApiController]
    public class Usuario: ControllerBase
    {
        /// <summary>
        ///     Este serviço permite autenticar usuário 
        /// </summary>
        /// <param name="loginViewModelInput"></param>
        /// <returns> Um objeto de com login e senha </returns>
        [SwaggerResponse(statusCode: 200, description: "Sucesso ao autenticar usuário", Type = typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode: 400, description: "Campos obrigatórios", Type = typeof(ValidarLoginViewModel))]
        [HttpPost]
        [Route("login")]
        [ValidationModelStateCustom]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput) 
        {
            return Ok(loginViewModelInput);
        }

        
        [HttpPost]
        [Route("registrar")]
        [ValidationModelStateCustom]
        public IActionResult Registrar(RegistroViewModelInput registroViewModelInput) 
        {
            return Created("", registroViewModelInput);
        }
    }
}