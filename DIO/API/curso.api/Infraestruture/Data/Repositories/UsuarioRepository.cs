using System.Linq;
using curso.api.Business.Entities;
using curso.api.Business.Repository;
using curso.api.Models.Usuarios;

namespace curso.api.Infraestruture.Data.Repositories
{
  public class UsuarioRepository : IUsuarioRepository
  {
    private readonly CursoDBContext _context;

    public UsuarioRepository(CursoDBContext context)
    {
        _context = context;
    }
    public void Adicionar(Usuario usuario)
    {
      _context.Add(usuario);
    }

    public void Commit()
    {
      _context.SaveChanges();
    }

    public Usuario getUser(string login)
    {
      return _context.Usuario.FirstOrDefault(u => u.Login == login);
    }
  }
}