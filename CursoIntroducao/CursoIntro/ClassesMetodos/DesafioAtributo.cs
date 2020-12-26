using System;

namespace CursoIntro.ClassesMetodos
{
    public class DesafioAtributo
    {
        int a = 10;
        public static void Executar()
        {
            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
        }
    }
}