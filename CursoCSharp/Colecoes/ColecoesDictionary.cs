using CursoCSharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>(); //A primeira coluna é a chave. Não pode repetir. Pode ser um
                                                        // int, string, Objeto.
                                                        //A segunda coluna é o valor, esse valor pode repetir.

            filmes.Add(2000, "Gladiador");  //.Add() é usado para adicionar uma chave-valor no dicionario
            filmes.Add(2002, "Homem-aranha");
            filmes.Add(2004, "Os incríveis");
            filmes.Add(2006, "Grande truque");

            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine("2004:" + filmes[2004]); //filmes[2004] serve para retornar o valor referente a
                                                           // chave informada. Dessa forma, caso a chave não exista no 
                                                           // dicionario. Irá gerar um erro

                Console.WriteLine("2004:" + filmes.GetValueOrDefault(2004));    //Retorna o valor referene a chave e
                                                                                //caso não exista irá retornar o padrão
                                                                                // do tipo.

                Console.WriteLine(filmes.ContainsValue("Os incríveis")); // Contais.Value verifica se existe o valor
                                                                         // Os incriveis dentro do dictionary

                Console.WriteLine($"Removeu? : {filmes.Remove(2004)}"); //Retornar um true caso consiga remover o dado do
                                                                        // dicionario, e caso não, retorna false

                //Outra forma de remover os dados de um dictionay
                filmes.TryGetValue(2006, out string filme2006); //busca o valor relacionado a dey 2006. e vai salvor
                                                                // na variável de saída out
                Console.WriteLine($"Filme {filme2006}!");

                //forma de percorrer o dictionary
                //percorer por key
                foreach (var chave in filmes.Keys)
                {
                    Console.WriteLine(chave);
                }

                foreach (var valor in filmes.Values)
                {
                    Console.WriteLine(valor);
                }

                foreach(KeyValuePair<int, string>filme in filmes)
                {
                    Console.WriteLine($"{filme.Value} e {filme.Key}");
                }

                foreach (var filme in filmes)
                {
                    Console.WriteLine($"{filme.Value} e {filme.Key}");
                }


            }

        }
    }
}
