using System;

namespace CursoIntro.ClassesMetodos
{
    public class Membros
    {
        public static void Executar()
        {
            Pessoa x = new Pessoa();
            x.Nome = "Adriano";
            x.AnoNascimento = new DateTime(1996, 7, 1);

            Console.WriteLine(x.Descrever());
            Console.WriteLine(x.CalcularIdade());
        }
    }
}