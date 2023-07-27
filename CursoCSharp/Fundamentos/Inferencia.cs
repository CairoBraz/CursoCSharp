using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            // usando var o compilador converte implicitamente o tipo da variável para o que ela foi atribuída
            var nome = "Leonardo";

            // quando a variável é usada implicitamente, não é possível usá-la novamnete para novo tipo
            // quando se usa a inferência, a variável deve ser declara e já ter valor atribuído
            // Não é possível converter implicitamente tipo "int" em "string"
            // nome = 123;

            Console.WriteLine(nome);

            // int idade; -> a variável pode ser declara sem atribuição
            var idade = 32; //-> A variável pode ser declarada e já ter valor atribuído
            Console.WriteLine(idade);

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine(a + b);

        }
    }
}
