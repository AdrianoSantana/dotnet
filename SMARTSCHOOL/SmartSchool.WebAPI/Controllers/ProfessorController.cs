using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.Dtos;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController: ControllerBase
    {
        private readonly IRepository _repo;
        private readonly IMapper _mapper;

        public ProfessorController(IRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get() {
            var professores = _repo.GetAllProfessores();
            var professoresDto = _mapper.Map<IEnumerable<ProfessorDto>>(professores);
            return Ok(professoresDto);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) {
            var professorProcurado = _repo.GetProfessorById(id);
            if (professorProcurado == null) return BadRequest("Não existe um professor com este ID!");
            var professorProcuradoDto = _mapper.Map<ProfessorDto>(professorProcurado);
            return Ok(professorProcuradoDto);
        }

        [HttpPost]

        public IActionResult Post(ProfessorRegistrarDto professor)
        {
           
            _repo.Add( _mapper.Map<Professor>(professor));
            if (_repo.SaveChanges())
            {
                return Ok( _mapper.Map<Professor>(professor));
            }
            return BadRequest("Professor não cadastrado!");
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var professorProcurado = _repo.GetProfessorById(id);
            if (professorProcurado == null) return BadRequest("Não existe professor com este Id");
            
            _repo.Delete(professorProcurado);
            if (_repo.SaveChanges())
            {
                return Ok("Professor deletado!");
            }
            return BadRequest("Professor não deletado!");
        }

        [HttpPut("{id}")]
        public IActionResult Put (int id, ProfessorRegistrarDto professorModel)
        {
            var professorProcurado = _repo.GetProfessorById(id);
            if (professorProcurado == null) return BadRequest("Não existe professor com este Id");
            _repo.Update(_mapper.Map(professorModel, professorProcurado));
            if (_repo.SaveChanges())
            {
                return Ok(_mapper.Map<Professor>(_mapper.Map(professorModel, professorProcurado)));
            }
            return BadRequest("Professor não atualizado!");
        }
    }
}