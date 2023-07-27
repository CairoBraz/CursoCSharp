using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMembros
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Cairo";
            sicrano.Idade = 26;

            Console.WriteLine("Olá, meu nome é {0} e tenho {1} anos!", sicrano.Nome, sicrano.Idade);

            sicrano.Zerar();

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa
            {
                Idade = 30,
                Nome = "Beatriz"
            };

            var ApresentacaoFulano = fulano.Apresentar();
            Console.WriteLine(ApresentacaoFulano);
            Console.WriteLine(ApresentacaoFulano.Length);

        }
    }
}
