using System;
using System.Globalization;

namespace CursoIntro.Fundamentos
{
    public class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 13.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("N1"));

            CultureInfo cultura = new CultureInfo("en-us");

            Console.WriteLine(valor.ToString("C", cultura));
        }
    }
}