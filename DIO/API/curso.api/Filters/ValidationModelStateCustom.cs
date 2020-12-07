using System.Linq;
using curso.api.Models.Validations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace curso.api.Filters
{
    public class ValidationModelStateCustom: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
        if (!context.ModelState.IsValid) {
                var validarCampoViewModel = new ValidarLoginViewModel(context.ModelState.SelectMany(sm => sm.Value.Errors).Select(s => s.ErrorMessage));
                context.Result = new BadRequestObjectResult(validarCampoViewModel);
            }
        }

    }
}