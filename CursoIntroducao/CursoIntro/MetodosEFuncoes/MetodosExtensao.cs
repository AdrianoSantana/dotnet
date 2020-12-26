namespace CursoIntro.MetodosEFuncoes
{
    public static class ExtensoesInteiro
    {
        public static int Soma(this int num, int outroNumero)
        {
            return num + outroNumero;
        }

        public static void Imprimir(this int num)
        {
            System.Console.WriteLine(num);
        }
    }
    public class MetodosExtensao
    {
        public static void Executar()
        {
            int a = 10;
            System.Console.WriteLine(a.Soma(40));
            a.Imprimir();
            (30 + 40).Imprimir();
        }
    }
}