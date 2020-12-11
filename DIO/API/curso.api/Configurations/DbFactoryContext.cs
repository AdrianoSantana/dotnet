using curso.api.Infraestruture;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace curso.api.Configurations
{
  public class DbFactoryContext : IDesignTimeDbContextFactory<CursoDBContext>
  {
    public CursoDBContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<CursoDBContext>();
        optionsBuilder.UseSqlite("Data Source=Curso.db");
        CursoDBContext context = new CursoDBContext(optionsBuilder.Options);

        return context;

    }
  }
}