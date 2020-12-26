namespace CursoIntro.MetodosEFuncoes
{
    delegate double Soma(double a, double b);
    delegate void ImprimirSoma(double a, double b);
    public class UsandoDelegate
    {
        static double MinhaSoma(double x, double y)
        {
            return x + y;
        }

        static void MeuImprimirSoma(double x, double y)
        {
            System.Console.WriteLine(x + y);
        }
        public static void Executar()
        {
            Soma op1 = MinhaSoma;
            ImprimirSoma imprimir = MeuImprimirSoma;

            System.Console.WriteLine($"Op1: {op1(10, 10)}");
            imprimir(30, 5);
        }
    }
}