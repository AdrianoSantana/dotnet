using System;

namespace CursoIntro.Excecoes
{
    public class NegativoException : Exception
    {
        public NegativoException() { }
        public NegativoException(string message) : base(message) { }

        public NegativoException(string message, Exception innerException) : base(message, innerException) { }

    }

    public class ImparException : Exception
    {
        public ImparException(string message) : base(message) { }
    }
    public class Personalizadas
    {
        public static void Executar()
        {

        }
    }
}