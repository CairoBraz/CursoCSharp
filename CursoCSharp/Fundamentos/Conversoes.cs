using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            // Conversão do tipo implicita. Pois o tipo quebrado armazena mais que o tipo inteiro e não há risco de perca de dados
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 7.5;
            // Não possível ocorrer conversão implícita  de um tipo menor para um maior, pois pode haver perca de dados
            //int notaTruncada = nota; -> Não é possível converter implidamente
            int notaTruncada = (int)nota; //-> Sintaxe do Cast
            Console.WriteLine("Nota truncada {0}", notaTruncada);

            // string para numero
            // Usando int.Parse() caso seja informado um valor que não possa ser convertido. A aplicação gera uma exceção
            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInt = int.Parse(idadeString);
            Console.WriteLine(idadeInt);

            // É possível realizar a conversão também usando a classe Convert
            Console.WriteLine("Digite sua idade2: ");
            string idadeString2 = Console.ReadLine();
            int idadeInt2 = Convert.ToInt32(idadeString2);
            Console.WriteLine(idadeInt2);

            // Usando o TryParse, caso seja informado um valor não válido o retorno será o padrão do tipo.
            // O padrão do int é o 0
            Console.WriteLine("digite um numero: ");
            int.TryParse(Console.ReadLine(), out int numeroDigitado);
            Console.WriteLine(numeroDigitado);

        }
    }
}
