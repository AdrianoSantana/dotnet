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

        public ProfessorController(DataContext context)
        {
            _context = context;
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
            _context.Add(professor);
            _context.SaveChanges();
            return Ok("Professor inserido!");
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var professorProcurado = _context.Professores.FirstOrDefault(professor => professor.Id == id);
            if (professorProcurado == null) return BadRequest("Não existe professor com este Id");
            _context.Remove(professorProcurado);
            _context.SaveChanges();
            return Ok("Professor deletado!");
        }

        [HttpPut("{id}")]
        public IActionResult Put (int id, Professor profesor)
        {
             var professorProcurado = _context.Professores.AsNoTracking().FirstOrDefault(professor => professor.Id == id);
            if (professorProcurado == null) return BadRequest("Não existe professor com este Id");
            _context.Update(profesor);
            _context.SaveChanges();
            return Ok("Professor editado!");
        }
    }
}