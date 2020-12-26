using System.Collections.Generic;

namespace CursoIntro.OO
{
    public class Interfacee
    {
        public interface OperacaoBinaria
        {
            int Operacao(int a, int b);
        }

        class Soma : OperacaoBinaria
        {
            public int Operacao(int a, int b)
            {
                return a + b;
            }
        }

        class Subtracao : OperacaoBinaria
        {
            public int Operacao(int a, int b)
            {
                return a - b;
            }
        }

        public class Calculadora
        {
            public List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
            {
                new Soma(),
                new Subtracao()
            };

            public string ExecutarOperacoes(int a, int b)
            {
                string resultado = "";
                foreach (var item in operacoes)
                {
                    resultado += $"Usando {item.GetType().Name} = {item.Operacao(a, b)} \n";
                }

                return resultado;
            }
        }
        public static void Executar()
        {
            Calculadora c1 = new Calculadora();
            System.Console.WriteLine(c1.ExecutarOperacoes(10, 20));

        }
    }
}