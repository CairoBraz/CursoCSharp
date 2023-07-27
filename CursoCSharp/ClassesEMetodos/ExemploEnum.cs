using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero
    {
        Acao,
        Aventura,
        Terror,
        Animacao,
        Comedia
    };

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    internal class ExemploEnum
    {
        public static void Executar()
        {
            int id = (int)Genero.Terror;
            Console.WriteLine(id);

            var filme = new Filme();
            filme.GeneroDoFilme = Genero.Acao;
            filme.Titulo = "Thor";

            Console.WriteLine("O filme {0} é do gênero {1}", filme.Titulo, filme.GeneroDoFilme );
        }
    }
}
