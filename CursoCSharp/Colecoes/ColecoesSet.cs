using System;
using System.Collections.Generic;


namespace CursoCSharp.Colecoes
{
    internal class ColecoesSet
    { 
        public static void Executar()
        {
            var livro = new Produto("Caos na guerra", preco: 55.99);

            var carrinho = new HashSet<Produto>(); //HashSet é uma estrutura não indexada e não aceita repetição
            carrinho.Add(livro);

            var combo = new HashSet<Produto>()
            {
                new Produto("A volta dos que não foram.", 11.25),
                new Produto("As tranças do rei careca.", 11.25),
                new Produto("As visões do cego.", 11.25),
            };

            carrinho.UnionWith(combo); //como não é uma estrtura indexada, eu não poso trabalhar com índice

            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);// o set é uma estrutura que não aceita repetição
        }
    }
}
