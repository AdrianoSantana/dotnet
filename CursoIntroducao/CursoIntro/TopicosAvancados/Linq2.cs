using System.Collections.Generic;
using System.Linq;

namespace CursoIntro.TopicosAvancados
{
    public class Linq2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>()
            {
                new Aluno() { Nome = "Adriano", Idade = 24, Nota = 9.1},
                new Aluno() { Nome = "Jamilton", Idade = 23, Nota = 5.1},
                new Aluno() { Nome = "Zeus", Idade = 21, Nota = 7.1},
                new Aluno() { Nome = "Carlos", Idade = 32, Nota = 4.3},
                new Aluno() { Nome = "Adriano", Idade = 32, Nota = 4.3},
                new Aluno() { Nome = "Julia", Idade = 21, Nota = 7.3},
                new Aluno() { Nome = "Bardão", Idade = 23, Nota = 8.3},
            };

            var aluno = alunos.Single(aluno => aluno.Nome.Equals("Bardão"));
            System.Console.WriteLine($"{aluno.Nome}");

            aluno = alunos.FirstOrDefault(aluno => aluno.Idade.Equals(21));
            System.Console.WriteLine(aluno.Nome);

            int somaIdade = alunos.Sum(a => a.Idade);
            System.Console.WriteLine(somaIdade);

            double idadeMax = alunos.Max(a => a.Idade);
            System.Console.WriteLine(idadeMax);

            for (var i = 0; i < alunos.Count; i++)
            {
                System.Console.WriteLine($"Iteração {i}");
                var result = alunos.Skip(i).Take(2).Select(aluno => aluno.Idade);
                foreach (var item in result)
                {
                    System.Console.WriteLine(item);
                }
            }
        }
    }
}