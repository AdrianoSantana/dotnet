using System;

namespace CursoIntro.ClassesMetodos
{
    public class ReadOnly
    {
        public class Cliente {
            public string nome;
            private readonly DateTime _nascimento;

            public Cliente(string nome, DateTime nascimento)
            {
                this.nome = nome;
                _nascimento = nascimento;
            }

            public string GetDataNascimento()
            {
                return String.Format("{0:D2}/{1:D2}/{2}", _nascimento.Day, _nascimento.Month, _nascimento.Year);
            }
    }
        public static void Executar()
        {
            var cliente = new Cliente("Adriano", new DateTime(1996,07,01));
            Console.WriteLine(cliente.GetDataNascimento());
        }
    }
}