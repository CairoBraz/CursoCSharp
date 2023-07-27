using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;
            do
            {
                Console.Write("Informe um nome: ");
                entrada = Console.ReadLine();

                Console.WriteLine($"Seja bem vindo {entrada}!");
                Console.Write("Deseja continuar? (S/N)");
                entrada = Console.ReadLine();

            } while (entrada.ToLower() == "s");
            Console.WriteLine("Fim do Programa!");
        }
    }
}
