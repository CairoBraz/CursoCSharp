using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class FilhoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoReconhecido...");

            Console.WriteLine(InfoPublica); //publico = todos
            Console.WriteLine(CorDoOlho); //protected = herança
            Console.WriteLine(NumeroCelular); //internal = dentro do mesmo assembly
            Console.WriteLine(JeitoDeFalar); //protected internal = herança OU mesmo assembly
            Console.WriteLine(SegredoFamilia);  // private protected = mesma classe ou herança apenas do mesmo assembly
            //Console.WriteLine(UsaMuitoPhotoshop); // private = apenas dentro da própria classe

        }
    }
}
