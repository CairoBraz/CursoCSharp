using System;
using System.Collections.Generic;
using System.Text;
using static CursoCSharp.ClassesEMetodos.Readonly;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Readonly
    {
        public class Cliente
        {
            public string Nome;
            public readonly DateTime Nascimento; // Com readonly, eu consigo iniciar a variável e depois atribuir valor no contrutor.
            //const DateTime Nascimento; // Com const, eu deveria criar a variável e já atribuir um valor. Não é possível atribuir no contrutos // DateTime não poder const
            //const int x = 0; // O tipo inteiro pode ser const

            public Cliente(string nome, DateTime nascimento)
            {
                Nome = nome;
                Nascimento = nascimento;

                //Nascimento = new DateTime(2022, 02, 01);
            }

            public Cliente()
            {

            }

            public string GetDataNascimento()
            {
                return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
            }



        }
        public static void Executar()
        {
            var cliente = new Cliente("Ana", new DateTime(2022, 02, 18));

            Console.WriteLine(cliente.Nome);
            Console.WriteLine(cliente.GetDataNascimento());

            //cliente.Nascimento = new DateTime(2022, 02, 01);// Não compila mesmo se Nascimento for public, pois é readonly e nao pode ser alterado depois de iniciado

            var cliente2 = new Cliente();
            cliente2.Nome = "Maria";
            //cliente2.Nascimento = new DateTime(2000, 02, 01);// Nao funciona pois o campo é readonly.
        }
    }
}
