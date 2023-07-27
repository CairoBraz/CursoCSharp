using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            // O valor digitado sempre é salvo como string
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            // Para ser lido como int ou double, é preciso fazer o parse
            Console.Write("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            
            // Para separar as casas decimais, usasse o ',' para o Sist Ope em portugues
            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos. Quero receber R${salario} um dia!");

            // È possível determinar que a aplicação sempre use o '.' como separador de casa decimal

            Console.Write("Qual é o seu salário? ");
            double salario2 = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture); ;
            Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos. Quero receber R${salario2} um dia!");


        }
    }
}
