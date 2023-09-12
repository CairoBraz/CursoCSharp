using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoObjetos
{
    public abstract class Celular   // A classe abstract não poderá ser instanciada.
    {
        public abstract string Assistente();    // O método abstract deverá ser implementado por qualquer classe concreta que herdar da classe abstract

        public string Tocar()   // O metodo concreto não é obrigatório de ser implementado por quem herdar da classe abastract
        {
            return "Trin Trin Trin...";
        }
    }
    public class Samsung : Celular
    {
        public override string Assistente() // Como o método será sobrescrevido, deverá ter o override
        {
            return "Olá! Meu nome é Bixby!";
        }
    }
    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Olá, meu nome é Siri!";
        }
    }
    class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new Samsung(),
                new Iphone()
            };

            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }

        }
    }
}
