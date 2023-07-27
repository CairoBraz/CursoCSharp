using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            var marca = "Dell";
            double preco = 5800.00;

            // Interpolacao comum, usando o '+'.
            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + ".");

            // Interpolacao usando índice
            Console.WriteLine("O {0} da marca {1} custa {2}. Pois é {0}", nome, marca, preco);

            // Interpolacao usando '$"
            Console.WriteLine($"O {nome} da marca {marca} custa {preco}.");
            Console.WriteLine($"A soma de 1 + 1 = {1+1}.");

        }
    }
}
