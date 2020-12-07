using System.ComponentModel.DataAnnotations;

namespace curso.api.Models.Usuarios
{
    public class RegistroViewModelInput
    {
        [Required(ErrorMessage = "Login é obrigatório!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Email é obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é obrigatório!")]
        public string Senha { get; set; }
    }
}