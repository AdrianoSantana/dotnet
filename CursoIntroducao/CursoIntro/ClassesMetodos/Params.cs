using System;

namespace CursoIntro.ClassesMetodos
{
    public class Params
    {
        public static void Recepcionar(params string[] pessoas)
        {
            if (pessoas.Length > 0)
            {
                foreach(var pessoa in pessoas)
                {
                    Console.WriteLine($"Olá, {pessoa} ");
                }
            }
            else
            {
                Console.WriteLine("Ninguem chegou!");
            }
        }
        public static void Executar()
        {
            Params.Recepcionar("Adriano", "A", "B", "C");
            Params.Recepcionar("Milena");
            Params.Recepcionar();
        }
    }
}