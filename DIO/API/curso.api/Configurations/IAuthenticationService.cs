using curso.api.Models.Usuarios;
using Microsoft.Extensions.Configuration;

namespace curso.api.Configurations
{
    public interface IAuthenticationService
    {
        public string GetToken(UsuarioViewModelOutput usuarioViewModelOutput);
    }
}