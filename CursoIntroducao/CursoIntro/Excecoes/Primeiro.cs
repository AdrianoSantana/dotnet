using System;

namespace CursoIntro.Excecoes
{
    public class Conta
    {
        private double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public double Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente");
            }
            else
            {
                Saldo -= valor;
                return Saldo;
            }
        }
    }
    public class Primeiro
    {
        public static void Executar()
        {
            Conta c1 = new Conta(1500);
            try
            {
                System.Console.WriteLine(c1.Sacar(2000));
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Ocorreu um erro ao executar transação! Motivo: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}