using System;
using System.Collections.Generic;
using System.Text;
using Encapsulamento;

namespace CursoCSharp.OrientacaoObjetos
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoNaoReconhecido...");

            Console.WriteLine(InfoPublica); //publico = todos
            Console.WriteLine(CorDoOlho); //protected = herança
            //Console.WriteLine(NumeroCelular); //internal = dentro do mesmo assembly
            Console.WriteLine(JeitoDeFalar); //protected internal = herança OU mesmo assembly
            //Console.WriteLine(SegredoFamilia);  // private protected = mesma classe ou herança apenas do mesmo assembly
            //Console.WriteLine(UsaMuitoPhotoshop); // private = apenas dentro da própria cla
        }
    }
    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("AmigoDistante...");

            Console.WriteLine(amiga.InfoPublica); //publico = todos
            //Console.WriteLine(amiga.CorDoOlho); //protected = herança
            //Console.WriteLine(amiga.NumeroCelular); //internal = dentro do mesmo assembly
            //Console.WriteLine(amiga.JeitoDeFalar); //protected internal = herança OU mesmo assembly
            //Console.WriteLine(amiga.SegredoFamilia);  // private protected = mesma classe ou herança apenas do mesmo assembly
            //Console.WriteLine(amiga.UsaMuitoPhotoshop); //private = apenas a propria classe

        }
    }
    internal class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
