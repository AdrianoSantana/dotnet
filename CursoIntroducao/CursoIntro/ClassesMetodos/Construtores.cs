using System;

namespace CursoIntro.ClassesMetodos
{
  public class Construtores
  {
    class Carro
    {
      public int Ano { get; set; }
      public string Fabricante { get; set; }
      public string Modelo { get; set; }

      public Carro(int ano, string fabricante, string modelo)
      {
        this.Ano = ano;
        this.Fabricante = fabricante;
        this.Modelo = modelo;
      }

      public void Describe() {
        Console.WriteLine($"{this.Fabricante} , {this.Modelo}, {this.Ano} ");
      }

      public Carro() {

      }
    }
    public static void Executar()
    {
        Carro c1 = new Carro(1996, "BMW", "AX35");
        c1.Describe();
        Carro c2 = new Carro() {
            Ano = 1990,
            Fabricante = "Ford",
            Modelo = "Qualquer"
        };
        c2.Describe();
    }
  }
}