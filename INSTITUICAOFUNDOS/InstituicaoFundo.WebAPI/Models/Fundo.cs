using System.Collections.Generic;

namespace InstituicaoFundo.WebAPI.Models
{
    public class Fundo
    {
        public Fundo()
        {

        }

        public Fundo(int id, string razaoSocial, string dataInicio, double saldo)
        {
            this.Id = id;
            this.RazaoSocial = razaoSocial;
            this.DataInicio = dataInicio;
            this.Saldo = saldo;

        }
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string DataInicio { get; set; }

        public double Saldo { get; set; }

        /*
         Relação fundo --> fundoCotado 1:N 
         Um fundo possui vários fundos cotados um fundo cotado pertence a apenas um fundo
        */
        public IEnumerable<FundoCotado> FundosCotados { get; set; } // Um fundo possui varios fundos cotados

        /*
            Relação instituicao --- Fundo N:N
            Uma instituição possui vários fundos
            Fundos podem ser de várias instituições

        */
        public IEnumerable<InstituicaoFundo> InstituicoesFundos { get; set; }
    }
}