using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoObjetos
{
    interface Teste
    {
        bool Bla(string a);
    }
    public interface OperacaoBinaria
    {
        int Operacao(int a, int b);
    }

    public class Soma : OperacaoBinaria, Teste
    {
        public bool Bla(string a)
        {
            return true;
        }

        public int Operacao(int a, int b)
        {
            return a + b;
        }
    }

    public class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }

    public class Multiplicacao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    public class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
        {
            new Soma(),
            new Multiplicacao(),
            new Subtracao()
        };
        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";

            foreach (var op in operacoes)
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
            }

            return resultado;
        }
    }

    internal class Interface
    {
        public static void Executar()
        {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(20, 5);
            Console.WriteLine(resultado);
        }
    }
}
