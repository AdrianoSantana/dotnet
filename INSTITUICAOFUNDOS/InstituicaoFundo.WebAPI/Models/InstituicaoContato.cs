namespace InstituicaoFundo.WebAPI.Models
{
    public class InstituicaoContato
    {
        public InstituicaoContato()
        {
            
        }

        public int InstituicaoId { get; set; } 

        public int ContatoId { get; set; } 

        public Instituicao Instituicao { get; set; }

        public Contato Contato { get; set; }
    }
}