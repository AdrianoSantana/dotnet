using System;

namespace CursoIntro.ClassesMetodos
{
    public class MetodosEstaticos
    {
        public class CalculadoraEstatica {
            public static int Somar(int a, int b)
            {
                return a+b;
            }

            public static int Multiplicar(int a, int b)
            {
                return a * b;
            }
        }
        public static void Executar() {
            Console.WriteLine(CalculadoraEstatica.Somar(10, 20));
            Console.WriteLine(CalculadoraEstatica.Multiplicar(10, 20));
        }
    }
}