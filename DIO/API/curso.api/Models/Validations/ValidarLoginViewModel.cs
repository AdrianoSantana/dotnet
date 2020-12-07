using System.Collections.Generic;

namespace curso.api.Models.Validations
{
    public class ValidarLoginViewModel
    {
        public IEnumerable<string> Erros { get; set; }

        public ValidarLoginViewModel(IEnumerable<string> erros)
        {
            Erros = erros;
        }
    }
}