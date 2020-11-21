using System.Collections.Generic;

namespace InstituicaoFundo.WebAPI.Models
{
    public class Instituicao
    {
        public Instituicao()
        {

        }

        public Instituicao(int id, string razaoSocial, string cnpj, string tipo)
        {
            this.Id = id;
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.Tipo = tipo;

        }
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Tipo { get; set; }

        /*
            Relação instituicao --- Fundo N:N
            Uma instituição possui vários fundos
            Fundos podem ser de várias instituições

        */

        public IEnumerable<InstituicaoFundo> InstituicoesFundos { get; set; }

        /*
            Relação Instituicao Contatos
            Uma instituição possui N Contatos
            Um Contato pode ser de várias instituiçãos
        */
        public IEnumerable<InstituicaoContato> InstituicoesContatos { get; set; }

    }
}