using System;

namespace CursoIntro.OO
{
    public class Carro
    {
        protected readonly int _velocidadeMaxima;

        private string Marca = "Fiat";
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            _velocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > _velocidadeMaxima)
            {
                VelocidadeAtual = _velocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }

        public virtual int Frear()
        {
            return AlterarVelocidade(-5);
        }

    }
    public class Uno : Carro
    {
        public Uno() : base(50)
        {

        }


    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(500)
        {

        }

        public override int Acelerar()
        {
            return this.AlterarVelocidade(50);
        }

        public override int Frear()
        {
            return this.AlterarVelocidade(-20);
        }
    }
    public class Heranca
    {
        public static void Executar()
        {
            System.Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());


            System.Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();

            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());

        }
    }
}