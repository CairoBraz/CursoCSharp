using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    internal class MetodosEstaticos
    {
        public class CalculadoraEstatica
        {
            // Mètodo estático ou Método de Classe, não existe instância. O método pertence a classe
            public static int  Multiplicar(int a, int b)
            {
                return a * b;
            }

            // Método de instância, para acessar é necessário instânciar um objeto da classe.
            public int Somar(int a, int b)
            {
                return a + b;
            }
        }
        public static void Executar()
        {
            Console.WriteLine("O resultado da multiplicação é: {0}", CalculadoraEstatica.Multiplicar(2, 2));

            CalculadoraEstatica calculadoraEstatica = new CalculadoraEstatica();
            Console.WriteLine("O resultado da soma é: {0}", calculadoraEstatica.Somar(3, 3));

        }
    }
}
