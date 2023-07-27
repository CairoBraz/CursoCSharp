using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;

            // converter o valor para string e travar a quantidade de casas decimais.
            Console.WriteLine(valor.ToString("F1")); // Ele arredonda o valor das casas decimais

            // Converter o valor para string e retornar como moeda
            Console.WriteLine(valor.ToString("C"));

            // Converter o valor para string e retornar como PERCENTUAL
            Console.WriteLine(valor.ToString("P")); // é multiplicado por 100 e adicionado o %

            // Definir a quantidade de casas decimais
            Console.WriteLine(valor.ToString("#.##"));

            // Posso travar a aplicação para um formato específico
            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C3", cultura));

            System.Globalization.CultureInfo cultura2 = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", cultura2));

            // Para completar um int com 0 a direita
            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
  