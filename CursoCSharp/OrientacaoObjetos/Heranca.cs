using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OrientacaoObjetos
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima; //protected(transmitida por herança) readonly(apenas leitura)
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        public virtual int Acelerar() //operador virtual possibilita que o método Acelerar possa ser sobrescrevido usando o override
        {
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro
    {
        public Uno() : base(200)
        {

        }
    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(350) 
        {

        }


        //SOBRESCREVER
        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }

        //OCULTAR
        public new int Frear()
        {
            return AlterarVelocidade(-15);
        }

    }
    public class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrai...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());   //O método está sobrescrito, vai chamar o comportamento da instância
            Console.WriteLine(carro2.Acelerar());   //O método está sobrescrito, vai chamar o comportamento da instância
            Console.WriteLine(carro2.Frear()); // O méotdo está oculto, vai chamar o comportamento do tipo generico
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com tipo Carro");
            Carro carro3 = new Ferrari(); //Polimorfismo
            Console.WriteLine(carro3.Acelerar()); //O método está sobrescrito, vai chamar o comportamento da instância
            Console.WriteLine(carro3.Acelerar());   //O método está sobrescrito, vai chamar o comportamento da instância
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());  // O méotdo está oculto, vai chamar o comportamento do tipo generico
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com tipo Carro");
            carro3 = new Uno();     //Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}
