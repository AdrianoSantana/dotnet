using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController: ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno> {
            new Aluno() {
                Id = 1,
                Nome = "Adriano",
                Sobrenome = "Santana",
                Telefone = "81 9 9502 9086"
            },
            new Aluno() {
                Id = 2,
                Nome = "AAAAAAAAA",
                Sobrenome = "Santana",
                Telefone = "81 9 9502 9086"
            },
            new Aluno() {
                Id = 3,
                Nome = "Laura",
                Sobrenome = "Santana",
                Telefone = "81 9 9502 9086"
            },
        };
        public AlunoController()
        {
            
        }

        [HttpGet]
        public IActionResult Get() {
            return Ok(Alunos);
        }

        // /api/aluno/byId?Id=2
        [HttpGet("{id}")]
        public IActionResult GetById(int id) {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("Não existe um aluno com este Id");
            return Ok(aluno);
        }

        // /api/aluno/nome

        [HttpGet("byName")]
        public IActionResult GetByName(string nome, string sobrenome) {
            var aluno = Alunos.FirstOrDefault(a => a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome));
            if (aluno == null) return BadRequest("Não existe um aluno com este nome");
            return Ok(aluno);
        }

        [HttpPost]

        public IActionResult Post(Aluno aluno) {
            return Ok(aluno);
        }

        [HttpPut("{id}")]

        public IActionResult Put(int id, Aluno aluno) {
            return Ok(aluno);
        }

         [HttpDelete("{id}")]

        public IActionResult Delete(int id) {
            return Ok();
        }
    }
}