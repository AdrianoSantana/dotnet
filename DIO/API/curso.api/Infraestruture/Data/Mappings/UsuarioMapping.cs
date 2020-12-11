using curso.api.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace curso.api.Infraestruture.Data.Mappings
{
  public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
  {
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
      builder.ToTable("TB_USUARIO"); // Criando tabela a partir de usuário
      builder.HasKey(p => p.Codigo); // Declarando chave primária
      builder.Property(p => p.Codigo).ValueGeneratedOnAdd(); // A chave sera identity O valor é gerado automaticamente
      builder.Property(p => p.Email); // Gera uma coluna Email
      builder.Property(p => p.Login); 
      builder.Property(p => p.Senha);

    }
  }
}