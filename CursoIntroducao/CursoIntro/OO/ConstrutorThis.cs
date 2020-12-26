namespace CursoIntro.OO
{
    public class Animal
    {
        public string Nome { get; set; }
        public Animal(string nome)
        {
            Nome = nome;
        }
    }

    public class Cachorro : Animal
    {
        public double Altura { get; set; }
        public Cachorro(string nome) : base(nome)
        {
            System.Console.WriteLine($"Cachorro {this.Nome} foi inicializado");
        }

        public Cachorro(string nome, double altura) : this(nome)
        {
            Altura = altura;
        }

        public override string ToString()
        {
            return $"{this.Nome} tem {this.Altura}cm de altura";
        }
    }
    public class ConstrutorThis
    {

        public static void Executar()
        {
            var c1 = new Cachorro("cachorro 1");
            var c2 = new Cachorro("cachorro 2", 40.0);

            System.Console.WriteLine(c1);
            System.Console.WriteLine(c2);
        }
    }
}