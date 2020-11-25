using InstituicaoFundo.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace InstituicaoFundo.WebAPI.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Fundo> Fundos { get; set; }

        public DbSet<Instituicao> Instituicoes { get; set; }

        public DbSet<FundoCotado> FundosCotados { get; set; }

        public DbSet<Contato> Contatos { get; set; }

        public DbSet<InstituicaoContato> InstituicoesContatos { get; set; }

        public DbSet<FundoInstituicao> InstituicoesFundos { get; set; }

        protected override void OnModelCreating (ModelBuilder builder)
        {
            builder.Entity<InstituicaoContato>().HasKey(AD => new { AD.InstituicaoId, AD.ContatoId });
            builder.Entity<FundoInstituicao>().HasKey(AD => new { AD.InstituicaoId, AD.FundoId });
        }

    }
}