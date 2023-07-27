using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota inválida: {0}", nota > 10.0);
            Console.WriteLine("Nota inválida: {0}", nota < 0.0);
            Console.WriteLine("Perfeito: {0}", nota == 10);
            Console.WriteLine("Pode melhorar: {0}", nota != 10);
            Console.WriteLine("Teve média: {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperacao: {0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado: {0}", nota <= 3);



        }
    }
}
