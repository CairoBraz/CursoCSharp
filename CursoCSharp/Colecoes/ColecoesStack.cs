using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new System.Collections.Stack(); //.collection não usa Generics. Portanto é heterogenea

            pilha.Push(3); //push adiciona elemento na pilha
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");  //na pilha, o utlimo a entrar é o primeiro a sair
                                            //nesse caso o primeiro a ser impresso será o 3.14
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}");//o comando pop retira da pilha o útlimo elemento adicionado
                                                       //nesse caso ele vai sacar o 3,14 e imprimir ele
            foreach (var item in pilha)
            {
                Console.Write($"{item} ");  //na pilha, o utlimo a entrar é o primeiro a sair
                                            //nesse caso o primeiro a ser impresso será o true
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}"); //Peek() server para exibir o ultimo elemento adicionado a fila
                                                        //mas não faz a retirada desse elemento da pilha.
            Console.WriteLine(pilha.Count);


        }
    }
}
