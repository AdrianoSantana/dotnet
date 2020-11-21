namespace InstituicaoFundo.WebAPI.Models
{
    public class InstituicaoFundo
    {
        public InstituicaoFundo()
        {

        }
        public InstituicaoFundo(int instituicaoId, int fundoId)
        {
            this.InstituicaoId = instituicaoId;
            this.FundoId = fundoId;

        }
        public int InstituicaoId { get; set; }

        public Instituicao Instituicao { get; set; }
        public int FundoId { get; set; }
        public Fundo Fundo { get; set; }


    }
}