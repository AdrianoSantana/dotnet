using System;

namespace CursoIntro.Fundamentos
{
    public class First
    {
        public static void Executar() {
            var saudacao = "ola".ToUpper().Insert(3, " World!")
                .Replace(" World!", " Mundo!");
            Console.WriteLine(saudacao);
        }
    }
}