using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    interface Ponto
    {
        void MoverNaDiagonal(int delta);// Por padrão é públic -  Método de uma interface deve ser público             
    }
    struct Coordenada : Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }


    }
    internal class ExStruct
    {
        
        public static void Executar()
        {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Coordenada inicial:");
            Console.WriteLine("Coordeanda X: {0}", coordenadaInicial.X);
            Console.WriteLine("Coordeanda Y: {0}", coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(x: 5, y: 10);
            coordenadaFinal.MoverNaDiagonal(40);

            Console.WriteLine("Coordenada final:");
            Console.WriteLine("Coordeanda X: {0}", coordenadaFinal.X);
            Console.WriteLine("Coordeanda Y: {0}", coordenadaFinal.Y);
        }
    }
}
