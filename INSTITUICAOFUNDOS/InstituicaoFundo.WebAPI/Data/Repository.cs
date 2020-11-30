using System.Linq;
using InstituicaoFundo.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace InstituicaoFundo.WebAPI.Data
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
            _context.Add(entity);
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
            return _context.SaveChanges() > 0;
        }

        public Instituicao[] GetAllInstituicoes()
        {
           IQueryable<Instituicao> instituicoes = _context.Instituicoes;
           return instituicoes.ToArray();
        }

        public Instituicao GetInstituicaoById(int id)
        {
            IQueryable<Instituicao> instituicoes = _context.Instituicoes;
            IQueryable<Instituicao> instituicao = instituicoes.Where(instituicao => instituicao.Id == id);
            return instituicao.FirstOrDefault();
        }
    }

}