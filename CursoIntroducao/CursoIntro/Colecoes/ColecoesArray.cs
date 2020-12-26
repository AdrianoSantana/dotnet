namespace CursoIntro.Colecoes
{
    public class ColecoesArray
    {
        public static void Executar()
        {
            string [] alunos = new string[5];
            alunos[0] = "A";
            alunos[1] = "B";
            alunos[2] = "C";
            alunos[3] = "D";
            alunos[4] = "E";

            foreach (var aluno in alunos)
            {
                System.Console.WriteLine(aluno);
            }
        }
    }
}