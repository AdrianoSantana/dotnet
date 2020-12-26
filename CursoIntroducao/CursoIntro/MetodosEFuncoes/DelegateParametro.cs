namespace CursoIntro.MetodosEFuncoes
{
    public class DelegateParametro
    {
        public delegate int Operacao(int x, int y);
        public static int Soma(int a, int b)
        {
            return a + b;
        }

        public static string Calculadora(Operacao operacao, int x, int y)
        {
            return operacao(x, y).ToString();
        }
        public static void Executar()
        {
            Operacao sub = (int a, int y) => a - y;
            System.Console.WriteLine(Calculadora(Soma, 30, 40));
            System.Console.WriteLine(Calculadora(sub, 40, 40));
        }
    }
}