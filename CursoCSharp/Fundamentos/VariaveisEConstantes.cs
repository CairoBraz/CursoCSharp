using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferência
            double raio = 4.5;
            // const faz com que essa variável não possa mais ser alterada em todo meu algorítmo
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415; // NÃO É POSSÍVEL ALTERAR O VALOR DA VARIÁVEL PI
            double area = PI * raio * raio;

            Console.WriteLine(area);
            // Como comecei com o string, o valor 100 iá concatenar com o começo da string
            Console.WriteLine("A área é " + area + 100);
            // Para que o valor 100 seja somado a variável 100 é preciso colocá-lo em parenteses
            Console.WriteLine("A área é " + (area + 100));

            // TIpos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo); ;

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            //Byte com sinal
            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("O salário é " + salario);

            // Mais usado dos inteiro
            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor int " + menorValorInt);

            // Inteiro sem sinal
            uint populacaoBrasileira = 207_600_001;
            Console.WriteLine("Populacao brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            // Long sem sinal
            ulong populacaoMundial = ulong.MaxValue;
            Console.WriteLine("Populacao Mundial " + populacaoMundial);

            // Tipos reais

            // Para valores literais, preciso confirmar que se trata de um float inserindo o F
            float precoComputador = 1999.65F; 
            Console.WriteLine("Preço do computador é " + precoComputador);

            // Mais usado dos reais
            double valorMercadoAple = 1_000_000_000.00;
            Console.WriteLine("Valor de mercado Aple " + valorMercadoAple);

            decimal distanciaEntreAsEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas " + distanciaEntreAsEstrelas);

            // Letras

            // char deve ser apenas uma letra e em aspas simples.
            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem-vindos ao curso de C#";
            Console.WriteLine(texto);
        }
    }
}
