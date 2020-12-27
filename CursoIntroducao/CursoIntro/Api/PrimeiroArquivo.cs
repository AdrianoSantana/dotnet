using System;
using System.IO;

namespace CursoIntro.Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (
                Environment.OSVersion.Platform == PlatformID.Unix ?
                Environment.GetEnvironmentVariable("HOME") :
                Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%")
            );
            return path.Replace("~", home);
        }
    }
    public class PrimeiroArquivo
    {
        public static void Executar()
        {
            string path = @"~/data/primeiroArquivo.csv".ParseHome();
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Nome, Idade");
                    sw.WriteLine("Adriano Santana, 24");
                }
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Santana, 40");
            }
        }
    }
}