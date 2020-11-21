using System.Collections.Generic;

namespace InstituicaoFundo.WebAPI.Models
{
    public class Contato
    {
        public Contato()
        {

        }

        public Contato(int id, string nome, string telefone, string cpf)
        {
            this.Id = id;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;

        }
        public int Id { get; set; }

        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        /*
            Relação Instituicao Contatos
            Uma instituição possui N Contatos
            Um Contato pode ser de várias instituiçãos
        */

        public IEnumerable<InstituicaoContato> InstituicoesContatos { get; set; }
    }
}