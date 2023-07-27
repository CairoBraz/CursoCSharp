using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Construtores
    {
        class Carro
        {
            public string Modelo;
            public string Fabricante;
            public int Ano;

            public Carro(string modelo, string fabricante, int ano)
            {
                //this.Modelo = Modelo;
                Modelo = modelo;
                Fabricante = fabricante;
                Ano = ano;
            }
            
            public Carro() { }
        }


        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;

            Console.WriteLine($" O carro é da {carro1.Fabricante} modelo {carro1.Modelo} e ano {carro1.Ano}");

            var carro2 = new Carro("Ka", "Ford", 2012);
            Console.WriteLine($" O carro é da {carro2.Fabricante} modelo {carro2.Modelo} e ano {carro2.Ano}");

            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2003
            };
            Console.WriteLine($" O carro é da {carro3.Fabricante} modelo {carro3.Modelo} e ano {carro3.Ano}");

        }
    }
}
