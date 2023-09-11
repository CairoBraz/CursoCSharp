using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class AmigoProximo
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("AmigoProximo...");

            Console.WriteLine(amiga.InfoPublica); //publico = todos
            //Console.WriteLine(amiga.CorDoOlho); //protected = herança
            Console.WriteLine(amiga.NumeroCelular); //internal = dentro do mesmo assembly
            Console.WriteLine(amiga.JeitoDeFalar); //protected internal = herança OU mesmo assembly
            //Console.WriteLine(amiga.SegredoFamilia);  // private protected = mesma classe ou herança apenas do mesmo assembly
            //Console.WriteLine(amiga.UsaMuitoPhotoshop); // private = apenas dentro da própria classe
        }
    }
}
