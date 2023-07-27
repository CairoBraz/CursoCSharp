using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.Write("Digite a nota do aluno: ");
            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Nota maior ou igual a 9");
            }
            else if (nota >= 7)
            {
                Console.WriteLine("Nota maior ou igual a 7 e menor que 9");
            }
            else if (nota >= 5)
            {
                Console.WriteLine("Nota maior ou igual a 5 e menor que 7");
            }
            else
            {
                Console.WriteLine("Nota menor que 5!");
            }

            Console.WriteLine("Fim do programa!");
        }
    }
}
