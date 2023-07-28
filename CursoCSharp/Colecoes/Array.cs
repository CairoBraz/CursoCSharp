using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];//o array é uma estrutura homogênea. Não tem como misturar mais de um tipo dentro do array.
                                            // a não ser que use tipo genérico
                                            // é uma estrutura estática. Não aumenta a quantiade de posições.
                                            // estrutura indexada. posição um é o índice 0, e assim por diante.
                                            // Array ~vc não acessa pelo nome. Somente por índice
            alunos[0] = "Cairo";
            alunos[1] = "Jessica";
            alunos[2] = "Luanne";
            alunos[3] = "Samuel";
            alunos[4] = "Pandora";
            //alunos[5] = "Jose"; //Ocorreu um erro: Index was outside the bounds of the array.

            //forma de varrer o array ítem a ítem
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double[] notas = { 9.1, 6.8, 9.8, 7.9, 7.8, 9.2 }; //outra forma de inicializar um array
            double somatorio = 0;
            foreach (var nota in notas)
            {
                somatorio += nota; //atribuição somativa
            }

            //for (int i = 0; i < notas.Length; i++)
            //{
            //    somatorio += notas[i];
            //}

            double media = somatorio / notas.Length;//.length acessa o tamanho do array
            Console.WriteLine(media);

            char[] letras = { 'a', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);

        }
    }
}
