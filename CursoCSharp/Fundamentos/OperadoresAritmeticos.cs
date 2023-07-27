using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {

            var preco = 1000.00;
            var imposto = 355;
            var desconto = 0.1;

            var total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine($"O valor com desconto é {totalComDesconto} !");

            // USANDO RAIZ
            // IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / (Math.Pow(altura, 2));
            Console.WriteLine("O resultado do imc de peso {0} e altura {1} é {2}.", peso, altura, imc);

            // Operador 'resto' ou 'modulo'
            int par = 10;
            int impar = 11;
            Console.WriteLine("O numero par {0} é par pois tem resto = {1}", par, par % 2);
            Console.WriteLine("O numero impar {0} não é par pois tem resto = {1}", impar, impar % 2);

        }
    }
}
