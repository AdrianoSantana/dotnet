using System;

namespace CursoIntro.MetodosEFuncoes
{
    public class ExemploLambda
    {
        public static void Executar()
        {
            Action algoConsole = () => System.Console.WriteLine("Função lambda");
            algoConsole();

            Func<int> jogarDado = () =>
            {
                return new Random().Next(1, 7);
            };

            System.Console.WriteLine(jogarDado());
        }
    }
}