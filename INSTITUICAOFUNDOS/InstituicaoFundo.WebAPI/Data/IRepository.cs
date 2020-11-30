using InstituicaoFundo.WebAPI.Models;

namespace InstituicaoFundo.WebAPI.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T:class;

        void Update<T>(T entity) where T:class;

        void Delete<T>(T entity) where T:class;

        bool SaveChanges();

        Instituicao[] GetAllInstituicoes();
        Instituicao GetInstituicaoById(int id);
    }
}