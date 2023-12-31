﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj)
        {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Preco);
        }

        //public override bool Equals(object obj)
        //{
        //    Produto outroProduto = (Produto)obj;

        //    bool mesmoNome = Nome == outroProduto.Nome;
        //    bool mesmoPreco = Preco== outroProduto.Preco;

        //    return mesmoNome && mesmoPreco; 
        //}
        //public override int GetHashCode() 
        //{
        //    return Nome.Length;
        //}
    }
    internal class ColecoesList
    {
        public static void Executar()
        {
            var livro = new Produto("Caos na guerra", preco: 55.99);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>()
            {
                new Produto("A volta dos que não foram.", 11.25),
                new Produto("As tranças do rei careca.", 11.25),
                new Produto("As visões do cego.", 11.25),
            };

            carrinho.AddRange(combo);

            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }
        }
    }
}
