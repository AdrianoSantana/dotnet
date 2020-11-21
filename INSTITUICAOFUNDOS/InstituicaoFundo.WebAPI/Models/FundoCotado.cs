namespace InstituicaoFundo.WebAPI.Models
{
    public class FundoCotado
    {
        public FundoCotado()
        {
            
        }
        public int Id { get; set; }
        public string Cnpj { get; set; }
        public bool ArtigoResolucao { get; set; }

        /*
         Relação fundo --> fundoCotado 1:N 
         Um fundo possui vários fundos cotados um fundo cotado pertence a apenas um fundo
        */
        public Fundo Fundo { get; set; } // Um fundo cotado pertence a um fundo
    }
}