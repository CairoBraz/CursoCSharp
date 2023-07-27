﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    internal class MetodosComRetorno
    {
        class CalculadoraComum
        {
            public int Somar(int a, int b)
            {
                return a + b;
            }

            public int Subtrair(int a, int b)
            {
                return a - b;
            }

            public int Multiplicar(int a, int b)
            {
                return a * b;
            }

        }
        class CalculadoraCadeia
        {
            int memoria;
            public CalculadoraCadeia Somar(int a)
            {
                memoria += a;
                return this;
            }
            public CalculadoraCadeia Subtrair (int a)
            {
                memoria -= a;
                return this;
            }
            public CalculadoraCadeia Multiplicar (int a)
            {
                memoria *= a;
                return this;
            }
            public CalculadoraCadeia Limpar()
            {
                memoria = 0;
                return this;
            }
            public CalculadoraCadeia Imprimir()
            {
                Console.WriteLine(memoria);
                return this;
            }
            public int Resultado()
            {
                return memoria;
            }
        }
        
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 6);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(10, 9));
            Console.WriteLine(calculadoraComum.Multiplicar(2, 2));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

            resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();

            Console.WriteLine(resultado);   

        }
    }
}
