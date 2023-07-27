using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Props
    {
        public class CarroOpcional
        {
            double desconto = 0.1;

            string nome;
            public string Nome
            {
                get
                {
                    return "Opcional: " + nome;
                }
                set
                {
                    nome = value;
                }
            }

            //Propriedade autoimplementada
            public double Preco { get; set; }

            //Propriedade somente leitura
            public double PrecoComDesconto
            {
                get => Preco - (Preco * desconto); //lambda
                //get
                //{
                //    return Preco - (Preco * desconto);
                //}
            }
            public CarroOpcional() { }

            public CarroOpcional(string nome, double preco)
            {
                //this.nome = nome;
                Nome = nome;
                Preco = preco;
            }

        }
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar condicionado", 3500);
            Console.WriteLine(op1.PrecoComDesconto);

            //op1.PrecoComDesconto = 1000;

            var op2 = new CarroOpcional();
            op2.Nome = "Vidro elétrico";
            op2.Preco = 2000;

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);

        }
    }
}
