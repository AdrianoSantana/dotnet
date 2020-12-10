using System;

namespace CursoIntro.ClassesMetodos
{
    public class Pessoa
    {
        public string Nome;

        public DateTime AnoNascimento;

        public int CalcularIdade()
        {
            int anoAtual = Int32.Parse(DateTime.Now.Year.ToString());
            int anoNascimento = Int32.Parse(AnoNascimento.Year.ToString());
            return anoAtual - anoNascimento;
        }

        public string Descrever()
        {
            return $"{this.Nome} tem {this.CalcularIdade()} anos ";
        }

        
    }
}