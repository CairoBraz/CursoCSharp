using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OrientacaoObjetos
{
    public class Animal
    {
        public string Nome { get; set; }
        public Animal(string nome)
        {
            Nome = nome;
        }
    }

    public class Cachorro : Animal
    {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome)
        {
            Console.WriteLine($"Cachorro {nome} inicializando");
        }

        public Cachorro(string nome, double altura) : this(nome)
        {
            Altura = altura;
        }

        public override string ToString()
        {
            return $"{Nome} tem {Altura}cm de altura!";
        }
    }

    internal class ContrutorThis
    {
        public static void Executar()
        {
            var spike = new Cachorro("Spike");
            var max = new Cachorro("Max", 35.00);

            Console.WriteLine(spike);
            Console.WriteLine(max);
        }
    }
}
