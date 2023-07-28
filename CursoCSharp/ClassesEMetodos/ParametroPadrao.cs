using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametroPadrao
    {
        public static int Somar(int a = 10, int b = 20)
        {
            return a + b;
        }
        public static void Executar()
        {
            Console.WriteLine(Somar());// vai imprimir a soma dos valores padrao 10 + 20 = 30
            Console.WriteLine(Somar(5, 9));// vai imprimir a soma dos valores informados 5 + 9 = 14
            Console.WriteLine(Somar(a: 20)); // vai somar o parametro passado a mais o padrao 20 + 20 =40
            Console.WriteLine(Somar(b: 55)); // vai somar o padrao de a + o passado de b = 10 + 55 = 65
        }
    }
}
