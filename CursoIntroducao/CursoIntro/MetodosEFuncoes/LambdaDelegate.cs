namespace CursoIntro.MetodosEFuncoes
{
    delegate double Operacao(double x, double y);
    public class LambdaDelegate
    {
        public static void Executar()
        {
            Operacao sum = (x, y) => x + y;
            Operacao multiplicacao = (x, y) => x * y;

            System.Console.WriteLine(sum(3, 2));
            System.Console.WriteLine(multiplicacao(3, 2));
        }
    }
}