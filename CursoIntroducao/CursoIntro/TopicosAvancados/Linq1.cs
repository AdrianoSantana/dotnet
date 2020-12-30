using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoIntro.TopicosAvancados
{
    public class Linq1
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

            System.Console.WriteLine("==============Aprovados===============");
            var aprovados = alunos.Where(aluno => aluno.Nota >= 7).OrderBy(aluno => aluno.Idade);
            foreach (var alunoAprovados in aprovados)
            {
                System.Console.WriteLine($"Nome: {alunoAprovados.Nome}, Nota: {alunoAprovados.Nota}, Idade: {alunoAprovados.Idade}");
            }

            System.Console.WriteLine("==============Chamada===============");
            var chamada = alunos.OrderBy(aluno => aluno.Nome).Select(aluno => aluno.Nome);
            foreach (var nome in chamada)
            {
                System.Console.WriteLine(nome);
            }

            System.Console.WriteLine("==============Aprovados por idade===============");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;

            foreach (var aluno in alunosAprovados)
            {
                System.Console.WriteLine(aluno);
            }

            System.Console.WriteLine("==============Aprovados por idade 2===============");
            var alunosAp = alunos.Where(aluno => aluno.Nota >= 7)
                                .OrderBy(aluno => aluno.Idade)
                                .Select(aluno => aluno.Nome);

            foreach (var aluno in alunosAp)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}