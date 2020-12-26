using System.Collections.Generic;
using System.Linq;

namespace CursoIntro.Colecoes
{
    public class Lista
    {
        public class Produto{
            public string Nome;
            public double Preco;

            public Produto(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }
        }
        public static void Executar()
        {
            var livro = new Produto("Livro GOT", 49.30);
            var carrinho = new List<Produto>();
            carrinho.Add(livro);
            carrinho.Add(new Produto("Caneta", 2.0));
            carrinho.Add(new Produto("Caneta", 5.0));
            
            foreach (var produto in carrinho)
            {
                System.Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.Preco}");
            }
        }
    }
}