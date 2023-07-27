using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            // Posso acessar os métodos de um objeto através do '.' e terminando com ().
            var saudacao = "olá".ToUpper().Insert(3, " world!").Replace("world", "mundo");
            Console.WriteLine( saudacao);

            // Também posso acessar as propriedades do objeto, nesse caso não se usa o ().
            Console.WriteLine("Teste".Length);

            // Preciso ter atenção ao acessar propriedades de um objeto vazio
            string valorImportante = null;
            //Console.WriteLine(valorImportante.Length); //Ocorreu um erro: Object reference not set to an instance of an object.
            // Posso utitlizar o ? para ignorar a propriedade caso o objeto seja nulo.
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
