using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            // negativo
            // negacao logica
            // incremento
            // decremento
            var valorNegativo = -5;
            Console.WriteLine(-valorNegativo); // Operador unário que troca o sinal de um número '-'

            var booleano = false;
            Console.WriteLine(!booleano); // Operador unário de negação lógica '!'

            var numero1 = 2;
            Console.WriteLine(numero1++); // Operador unario de incremento após a variável. Primeiro ele realiza o writeline e depois soma1
                                          // Devido a isto, o retorno ainda é 2 e só depois realiza a soma.
            Console.WriteLine(++numero1); // Operador unario de incremento antes da variável. Primeiro ele faz o incremente e depois faz o
                                          // Writeline. Por isso ele já imprime o número somado a +1

            numero1 = 2;
            var numero2 = 3;
            Console.WriteLine(numero1 ++ == --numero2); // O resultado é true, devido a ordem dos incrementos
            Console.WriteLine($"{numero1} {numero2}");


        }
    }
}
