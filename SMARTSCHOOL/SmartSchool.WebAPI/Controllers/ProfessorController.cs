using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController: ControllerBase
    {
        private readonly DataContext _context;
        private readonly IRepository _repo;

        public ProfessorController(DataContext context, IRepository repo)
        {
            _context = context;
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get() {
            var professores = _context.Professores;
            return Ok(professores);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) {
            var professorProcurado = _context.Professores.FirstOrDefault(professor => professor.Id == id);
            if (professorProcurado == null) return BadRequest("Não existe um professor com este ID!");
            return Ok(professorProcurado);
        }

        [HttpPost]

        public IActionResult Post(Professor professor)
        {
            _repo.Add(professor);
            if (_repo.SaveChanges())
            {
                return Ok(professor);
            }
            return BadRequest("Professor não cadastrado!");
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var professorProcurado = _context.Professores.FirstOrDefault(professor => professor.Id == id);
            if (professorProcurado == null) return BadRequest("Não existe professor com este Id");
            
            _repo.Delete(professorProcurado);
            if (_repo.SaveChanges())
            {
                return Ok("Professor deletado!");
            }
            return BadRequest("Professor não deletado!");
        }

        [HttpPut("{id}")]
        public IActionResult Put (int id, Professor professor)
        {
             var professorProcurado = _context.Professores.AsNoTracking().FirstOrDefault(professor => professor.Id == id);
            if (professorProcurado == null) return BadRequest("Não existe professor com este Id");
            
            _repo.Update(professor);
            if (_repo.SaveChanges())
            {
                return Ok(professor);
            }
            return BadRequest("Professor não atualizado!");
        }
    }
}