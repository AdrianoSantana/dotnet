using encapsul;

namespace CursoIntro.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            System.Console.WriteLine("Filho não reconhecido...");
            System.Console.WriteLine(this.InfoPublica);
            System.Console.WriteLine(this.CorDoOlho);
            System.Console.WriteLine(this.JeitoDeFalar);
        }
    }
    public class Encampsulamento
    {
        public static void Executar()
        {

        }
    }
}