using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var produto1 = new Produto("caneta", 2.45);
            var produto2 = new Produto("caneta", 2.45);

            Console.WriteLine(produto1 == produto2); // A resposta é false. Pois apontam para locais diferentes

            var p3 = produto2;

            Console.WriteLine(p3 == produto2); // A resposta é true. Pois é uma atribuicao por referencia
                                               // e por isso apontam para o mesmo local de memória

            Console.WriteLine(produto1.Equals(produto2)); //A resposta ainda é false. Pois o método Equals
                                                          // compara o endereço de memória.

            Console.WriteLine(produto1.Equals(produto2)); // Eu fiz o override do metodo Equals, agora ele compara
                                                            // os valores de nome e preco. Portanto passou a ser true
        }
    }
}
