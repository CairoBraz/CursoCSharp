using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoObjetos
{
    sealed class SemFilho // A classe selada não pode ser herdada por ninguém
    {
        public double ValorDaFortuna()
        {
            return 1_234_567.89;
        }
    }
    //class SouFilho : SemFilho // Dá erro de compilação, pois a classe é selada e não pode ter filhos
    //{

    //}

    class Avo
    {
        public virtual bool HonrarNomeFamilia() // Se o método é virtual, poderá ser sobrescrito
        {
            return true;
        }
    }

    class Pai : Avo
    {
        public sealed override bool HonrarNomeFamilia() //override vai sobrescrever o método virtual do avo, sealed irá impedir que o metodo
                                                        //possa ser sobrescrevido para quem herdar de pai
        {
            return true;
        }
    }

    class FilhoRebelde : Pai
    {
        //public override bool HonrarNomeFamilia() // não é possível sobrescrever o método sealed do Pai
        //{
        //    return false;
        //}

        //public new bool HonrarNomeFamilia() // é possível instaciar um novo método com mesmo nome que irá ocultar o método do pai
        //{
        //    return false;
        //}
    }

    internal class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}
