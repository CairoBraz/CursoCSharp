using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            Console.WriteLine(num1);

            num1 = 7;
            Console.WriteLine(num1);

            num1 += 10; // num1 = num1 + 10
            Console.WriteLine(num1);

            num1 -= 3; // num1 = num1 - 3
            Console.WriteLine(num1);

            num1 *= 5; // num1 = num1 * 5;
            Console.WriteLine(num1);

            num1 /= 2; // num1 = num1/2
            Console.WriteLine(num1);

            int a = 1;
            int b = a;
            Console.WriteLine("{0} e {1}", a, b);

            a++;
            Console.WriteLine("{0} e {1}", a, b);

            b--;
            Console.WriteLine("{0} e {1}", a, b);

            // Não se preocupe com o código
            // desta maneira, as duas variáveis compartilham o mesmo objeto
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";
            Console.WriteLine(c.nome);

            dynamic d = c;
            d.nome = "maria";
            Console.WriteLine(c.nome);
        }
    }
}
