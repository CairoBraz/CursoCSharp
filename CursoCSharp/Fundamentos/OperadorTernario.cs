using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            /* Operador Condicional
             * Expressão, operando caso verdadeiro, operando caso falso
             * Atribuiçao condicional 
             */
            var nota = 9.0;
            bool bomComportamento = true;
            var resultado = nota >= 7 && bomComportamento ? "aprovado": "reprovado"; 
            // Mesmo usando variável implícita, os dois termos precisam ter a mesma tipagem
        }
    }
}
