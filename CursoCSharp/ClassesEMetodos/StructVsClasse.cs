using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public struct SPonto
    {
        public int X;
        public int Y;
    }
    public class CPonto
    {
        public int X;
        public int Y;
    }
    internal class StructVsClasse
    {
        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; // Atribuição por VALOR!!

            ponto1.X = 5;

            Console.WriteLine("Ponto 1. X: {0}", ponto1.X);
            Console.WriteLine($"Cópia ponto 1. X:{copiaPonto1.X}");

            CPonto ponto2 = new CPonto { X = 10, Y = 40 };
            CPonto copiaDoPonto2 = ponto2; // Atribuição por referência

            ponto2.X = 55;
            Console.WriteLine($"Ponto 2. X: {ponto2.X}");
            Console.WriteLine($"Cópia do ponto 2. X: {copiaDoPonto2.X}");


        }
    }
}
