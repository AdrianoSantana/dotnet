using System;
using System.Globalization;

namespace CursoIntro.Fundamentos
{
    public class LendoDados
    {
        public static void Executar() 
        {
            Console.Write("Qual seu nome ? ");
            string nome = Console.ReadLine();

            Console.Write("Qual sua idade ? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual seu salário ? ");
            double sal = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            System.Console.WriteLine($"Nome: {nome}, Idade: {idade} e possui salário: {sal}");
        }
    }
}