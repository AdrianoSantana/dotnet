using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Data
{
    public interface IRepository
    {
       void Add<T>(T entity) where T: class;

       void Update<T>(T entity) where T: class;

       void Delete<T>(T entity) where T: class;

       bool SaveChanges();

        // Alunos
       Aluno[] GetAllAlunos(bool incluirDisciplina);
       Aluno[] GetAllAlunosByDisciplinaId(int disciplinaId, bool incluirProfessor = false);
       Aluno GetAlunoById(int id);

       // Professores

       Professor[] GetAllProfessores();
       Professor GetAllProfessoresByDisciplinaId(int disciplinaId);
       Professor GetProfessorById(int id);
    }
}