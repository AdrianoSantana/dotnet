using System;

namespace CursoIntro.ClassesMetodos
{
  public class AtributosEstaticos
  {
    public class Produto
    {
      public string Nome { get; set; }
      public double Preco { get; set; }
      public static double Desconto = 0.1;
      public Produto(string nome, double preco)
      {
        this.Nome = nome;
        this.Preco = preco;
      }
      public Produto ()
      {

      }

      public double CalcularDesconto()
      {
        return this.Preco - (this.Preco * Desconto);
      }
      
    }
    public static void Executar()
    {
        var produto1 = new Produto("Caneta", 3.2);
        var produto2 = new Produto()
        {
            Nome = "Borracha",
            Preco = 5.3,
        };

        Console.WriteLine($"Preço com desconto {produto1.CalcularDesconto()}");
        Console.WriteLine($"Preço com desconto {produto2.CalcularDesconto()}");
    }
  }
}