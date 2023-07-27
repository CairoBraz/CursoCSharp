using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine($"O valor de i é: {i}");
            //    i++;
            //}

            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine($"O valor de i é: {i}");
            //}


            Console.Write("Informe o tamanho da turma: ");
            int.TryParse(Console.ReadLine(), out int tamanhoDaTurma);

            double somatorio = 0;
            for (int i = 1; i <= tamanhoDaTurma; i++)
            {
                Console.Write("Informe a nota do aluno {0}: ", i);
                double.TryParse(Console.ReadLine(), out double notaAtual);
                
                somatorio += notaAtual;
            }

            Console.WriteLine($"A média da turma é : {(tamanhoDaTurma > 0 ? somatorio/tamanhoDaTurma : 0)}");

        }
    }
}
