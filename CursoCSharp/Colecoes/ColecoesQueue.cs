using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesQueue
    {
        public static void Executar()
        {
            //Queue ou Fila é utilizado para seguir a estrutura FIFO. FIRST IN FIRST OUT
            var fila = new Queue<string>();

            fila.Enqueue("Fulano"); // Eneque serve para adicionar o elemento na ordem da fila
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek()); // Peek serve pra retornar o proximo elemento a sair da fila
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue()); // Dequeue serve para tirar o proximo elemento da fila
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("item");
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item"));

        }
    }
}
