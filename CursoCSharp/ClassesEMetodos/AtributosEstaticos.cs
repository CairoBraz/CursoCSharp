using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    internal class AtributosEstaticos
    {
        
        public class Produto
        {
            public string Nome;
            public double Preco;
            public static double Desconto = 0.10;

            public Produto(string nome, double preco, double desconto)
            {
                Nome = nome;
                Preco = preco;
                Desconto= desconto;
            }
            public Produto()
            {

            }

            public double CalcularDesconto()
            {
                return Preco - Preco * Desconto;
            }
        }

        public static void Executar()
        {
            Produto produto1 = new Produto("Caneta", 3.50, 0.10);
            Produto produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 4.10
            };

            Produto.Desconto = 0.90;

            Console.WriteLine("O preço do produto {0} é {1}", produto1.Nome, produto1.CalcularDesconto());
            Console.WriteLine("O preço do produto {0} é {1}", produto2.Nome, produto2.CalcularDesconto());

            Produto.Desconto = 0.99;

            Console.WriteLine("O preço do produto {0} é {1}", produto1.Nome,produto1.CalcularDesconto());
            Console.WriteLine("O preço do produto {0} é {1}", produto2.Nome,produto2.CalcularDesconto());

            


            
        }
    }
}
