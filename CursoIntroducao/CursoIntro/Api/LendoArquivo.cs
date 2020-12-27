using System;
using System.IO;

namespace CursoIntro.Api
{
    public class LendoArquivo
    {
        public static void Executar()
        {
            var path = @"~/data/lendo_arquivos.txt".ParseHome();

            using (StreamWriter sw = File.AppendText(path))
            {
                if (!File.Exists(path))
                {
                    sw.WriteLine("Produto;Preco;Qtd");
                    sw.WriteLine("Caneta; 3.59; 80");
                    sw.WriteLine("Livro 1; 45.00; 20");
                }
            }

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    var texto = sr.ReadToEnd();
                    System.Console.WriteLine(texto);
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }
    }
}