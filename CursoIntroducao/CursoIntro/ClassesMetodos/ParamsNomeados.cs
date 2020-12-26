namespace CursoIntro.ClassesMetodos
{
    public class ParamsNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            System.Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }
        public static void Executar()
        {
            ParamsNomeados.Formatar(mes:7, dia:1, ano: 1998);
        }
    }
}