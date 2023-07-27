using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    internal class DesafioAtributo
    {
        int a = 50;
        public static void Executar()
        {
            var variavelDaClasse = new DesafioAtributo();
            Console.WriteLine(variavelDaClasse.a);
        }
    }
}
