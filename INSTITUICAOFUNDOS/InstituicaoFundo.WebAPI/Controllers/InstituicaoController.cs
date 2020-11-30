using InstituicaoFundo.WebAPI.Data;
using InstituicaoFundo.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstituicaoFundo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstituicaoController: ControllerBase
    {
        private readonly IRepository _repository;

        public InstituicaoController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAllInstituicoes());
        }

        [HttpPost]
        public IActionResult Add(Instituicao inst)
        {
            _repository.Add(inst);
            if (_repository.SaveChanges())
            {
                return Ok(inst);
            }
            return BadRequest("Não foi possivel inserir instituicao");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Instituicao instituicaoEncontrada = _repository.GetInstituicaoById(id);
            if (instituicaoEncontrada == null) return BadRequest("Não existe instituicao com este id");
            _repository.Delete(instituicaoEncontrada);
            if (_repository.SaveChanges())
            {
                return Ok("Instituiçaõ deletada!");
            }
            return StatusCode(500);
            
        }
    }
}