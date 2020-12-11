using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using curso.api.Models.Usuarios;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace curso.api.Configurations
{
  public class JwtService : IAuthenticationService
  {
    private readonly IConfiguration _configuration;

    public JwtService(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public string GetToken(UsuarioViewModelOutput usuarioViewModelOutput)
    {
        /*
        var usuarioViewModelOutput = new UsuarioViewModelOutput() {
            Codigo = 1,
            Email = "ans3@cin.ufpe.br",
            Login = "ans3"
        };
        */
        var secret = Encoding.ASCII.GetBytes(_configuration.GetSection("JwtConfigurations:Secret").Value);
        var symmetricSecurityKey = new SymmetricSecurityKey(secret);
        var securityTokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(
                new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, usuarioViewModelOutput.Codigo.ToString()),
                    new Claim(ClaimTypes.Name, usuarioViewModelOutput.Login.ToString()),
                    new Claim(ClaimTypes.Email, usuarioViewModelOutput.Email.ToString()),
                }
            ),
            Expires = DateTime.UtcNow.AddDays(1),
            SigningCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature)
        };
        var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
        var tokenGenerated = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);
        var token = jwtSecurityTokenHandler.WriteToken(tokenGenerated);

        return token;
    }
  }
}