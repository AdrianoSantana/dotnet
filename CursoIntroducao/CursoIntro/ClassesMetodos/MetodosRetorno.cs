using System;

namespace CursoIntro.ClassesMetodos
{
    class CalculadoraCadeia {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Subtrair(int a)
        {
            memoria -= a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar(int a)
        {
            memoria  = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine($"Valor: {this.memoria}");
            return this;
        }

        public int Resultado()
        {
            return this.memoria;
        }
    }
    class Calculadora {
        public int Somar(int a, int b)
        {
            return a+b;
        }
        public int Subtrair(int a, int b)
        {
            return a-b;
        }
        public int Multiplicar(int a, int b)
        {
            return a*b;
        }
        public int Dividir(int a, int b)
        {
            return a/b;
        }
    }
    public class MetodosRetorno
    {
        
        public static void Executar()
        {
            var calc = new Calculadora();
            System.Console.WriteLine(calc.Subtrair(5,5));

            var calc2 = new CalculadoraCadeia();
            calc2.Somar(10).Subtrair(3).Imprimir();
        }
    }
}