using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Helpers;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;
        public Repository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity); // Este método ADD pertence ao contexto do banco de dados
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0); // Retorna TRUE se ele salvou algo
        }
        public async Task<PageList<Aluno>> GetAllAlunosAsync(PageParams pageParams, bool incluirDisciplina)
        {
            IQueryable<Aluno> query = _context.Alunos;
            if (incluirDisciplina)
            {
               query = query.Include(a => a.AlunosDisciplinas) // Coloca dentro de alunos a tabela AlunosDisciplina
                    .ThenInclude(ad => ad.Disciplina) // Coloca dentro da tabela Alunos disciplina os dados da disciplina
                    .ThenInclude(d => d.Professor); // Coloca dentro da tabela disciplina os dados do professor que da a aula

            } 
            query = query.AsNoTracking().OrderBy(a => a.Id);
            //return await query.ToListAsync();
            return await PageList<Aluno>.CreateAsync(query, pageParams.PageNumber, pageParams.PageSize);
        }

        public Aluno[] GetAllAlunos(bool incluirDisciplina)
        {
            IQueryable<Aluno> query = _context.Alunos;
            if (incluirDisciplina)
            {
               query = query.Include(a => a.AlunosDisciplinas) // Coloca dentro de alunos a tabela AlunosDisciplina
                    .ThenInclude(ad => ad.Disciplina) // Coloca dentro da tabela Alunos disciplina os dados da disciplina
                    .ThenInclude(d => d.Professor); // Coloca dentro da tabela disciplina os dados do professor que da a aula

            } 
            query = query.AsNoTracking().OrderBy(a => a.Id);
            return query.ToArray();
        }

        public Aluno[] GetAllAlunosByDisciplinaId(int disciplinaId, bool incluirProfessor = false)
        {
            IQueryable<Aluno> query = _context.Alunos;
            if (incluirProfessor)
            {
               query = query.Include(a => a.AlunosDisciplinas) // Coloca dentro de alunos a tabela AlunosDisciplina
                    .ThenInclude(ad => ad.Disciplina) // Coloca dentro da tabela Alunos disciplina os dados da disciplina
                    .ThenInclude(d => d.Professor); // Coloca dentro da tabela disciplina os dados do professor que da a aula

            } 
            query = query.AsNoTracking()
                    .OrderBy(a => a.Id)
                    .Where(aluno => aluno.AlunosDisciplinas.Any(ad => ad.DisciplinaId == disciplinaId));
            return query.ToArray();
        }

        public Aluno GetAlunoById(int id)
        {
            IQueryable<Aluno> query = _context.Alunos;
            query = query.Where(aluno => aluno.Id == id)
                    .Include(a => a.AlunosDisciplinas)
                    .ThenInclude(ad => ad.Disciplina)
                    .ThenInclude(d => d.Professor);

            return query.FirstOrDefault();
        }

        public Professor[] GetAllProfessores()
        {
            IQueryable<Professor> query = _context.Professores;
            query = query.AsNoTracking().OrderBy(p => p.Id);
            return query.ToArray();
        }

        public Professor GetAllProfessoresByDisciplinaId(int disciplinaId)
        {
            IQueryable<Professor> query = _context.Professores;
            query = query.AsNoTracking()
                    .OrderBy(professor => professor.Id)
                    .Include(professor => professor.Disciplinas.Any(d => d.ProfessorId == professor.Id));
            return query.FirstOrDefault();
        }

        public Professor GetProfessorById(int id)
        {
            IQueryable<Professor> query = _context.Professores;
            query = query.AsNoTracking().OrderBy(professor => professor.Id)
                    .Where(professor => professor.Id == id);

            return query.FirstOrDefault();
        }
    }
}