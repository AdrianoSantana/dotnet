using curso.api.Business.Entities;

namespace curso.api.Business.Repository
{
    public interface IUsuarioRepository
    {
        void Adicionar(Usuario usuario);

        void Commit();

        Usuario getUser(string login);
    }
}