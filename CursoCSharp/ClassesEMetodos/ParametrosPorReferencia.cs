using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 10000;
        }
        public static void AlterarOut(out int numero1, out int numero2)
        {
            numero1 = 0;
            numero2 = 0;
            numero1 = numero1 + 50;
            numero2 = numero2 + 75;
        }
        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);//alterando o método para REF, agora a atribuicao de a dentro do método é por referencia.
                                 // portanto altera o valor e a cópia.

            //int b = 2; NÃO FAZ SENTIDO EU INICIAR, POIS ELA NÃO SERÁ UTILIZADO. O PARAMETRO OUT É APENAS SAIDA
            AlterarOut(out int b, out int c);
            Console.WriteLine($"{b} e {c}");
        }
    }
}
