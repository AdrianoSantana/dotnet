using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using curso.api.Filters;
using curso.api.Infraestruture;
using curso.api.Models.Usuarios;
using curso.api.Models.Validations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Annotations;
using curso.api.Business.Entities;
using curso.api.Configurations;
using curso.api.Business.Repository;
using Microsoft.Extensions.Configuration;

namespace curso.api.Controllers
{
    [Route("api/v1/usuario")]
    [ApiController]
    
    public class Usuario: ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        private readonly IAuthenticationService _authenticationService;

        public Usuario(IUsuarioRepository usuarioRepository, IAuthenticationService authenticationService)
        {
            _usuarioRepository = usuarioRepository;
            _authenticationService = authenticationService;
        }

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
            var user = _usuarioRepository.getUser(loginViewModelInput.Login);
            if (user == null) {
                return BadRequest("Ocorreu um erro");
            }

            var usuarioViewModelOutput = new UsuarioViewModelOutput()
            {
                Codigo = user.Codigo,
                Login = loginViewModelInput.Login,
                Email = user.Email
            };
            
            var token = _authenticationService.GetToken(usuarioViewModelOutput); 

            return Ok(new {
                Token = token,
                Usuario = usuarioViewModelOutput
            });
        }

        
        [HttpPost]
        [Route("registrar")]
        [ValidationModelStateCustom]
        public IActionResult Registrar(RegistroViewModelInput registroViewModelInput) 
        {

            var usuario = new curso.api.Business.Entities.Usuario();
            usuario.Login = registroViewModelInput.Login;
            usuario.Email = registroViewModelInput.Email;
            usuario.Senha = registroViewModelInput.Senha;

            
            _usuarioRepository.Adicionar(usuario);
            _usuarioRepository.Commit();

            

            return Created("", registroViewModelInput);
        }
    }
}