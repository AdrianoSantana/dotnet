namespace CursoIntro.ClassesMetodos
{
    public class Enuum
    {
        public enum Genero { Acao, Aventura, Terror, Animacao };

        public class Filme {
            public string Titulo { get; set; }
            public Genero GeneroFilme { get; set; }
        }
        public static void Executar()
        {
            int id = (int) Genero.Acao;
            System.Console.WriteLine(id);

            var filme = new Filme();
            filme.Titulo = "AAAAAAaa";
            filme.GeneroFilme = Genero.Aventura;
        }
    }
}