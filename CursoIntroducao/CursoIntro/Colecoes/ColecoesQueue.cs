using System.Collections.Generic;

namespace CursoIntro.Colecoes
{
    public class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();
            fila.Enqueue("Adriano");
            fila.Enqueue("Santana");
            fila.Enqueue("Nascimento");

            System.Console.WriteLine(fila.Peek());
            System.Console.WriteLine(fila.Count);
            System.Console.WriteLine(fila.Dequeue());
            System.Console.WriteLine(fila.Peek());
            System.Console.WriteLine(fila.Count);

            foreach (var item in fila)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}