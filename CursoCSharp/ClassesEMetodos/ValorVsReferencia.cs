using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente
    {
        public string Nome;//string vem  class String, portanto a cópia é por referência.
        public int Idade; //int vem de struct Int32, portanto a copia será por valor.
    }

    public struct DependenteStruct
    {
        public string Nome;//string vem  class String, portanto a cópia é por referência.
        public int Idade; //int vem de struct Int32, portanto a copia será por valor.
    }
    internal class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = 3;
            Console.WriteLine($"{numero} numero - {copiaNumero} copiaNumero");//A copia tambem será 3.

            numero++;
            Console.WriteLine($"{numero} numero - {copiaNumero} copiaNumero");// numero irá alterar, mas copia sera a mesma.
                                                                              // pois a copia de um int(struct) é por valor e não referência

            Dependente dep = new Dependente
            {
                Idade = 10,
                Nome = "Maria"
            };

            var copiaDep = dep;
            Console.WriteLine($"nome dep:{dep.Nome} - nome copia Dep:{copiaDep.Nome}"); //SERAO IGUAIS
            Console.WriteLine($"idade dep:{dep.Idade} - idade copia Dep:{copiaDep.Idade}"); //SERAO IGUAIS

            dep.Idade = 30;
            dep.Nome = "Rita";
            Console.WriteLine($"nome dep:{dep.Nome} - nome copia Dep: {copiaDep.Nome}"); //vão manter iguais, pois a copia é por referencia
            Console.WriteLine($"idade dep:{dep.Idade} - idade copia Dep: {copiaDep.Idade}"); //vão manter iguais, pois a copia é por referencia


            DependenteStruct depStruct = new DependenteStruct
            {
                Idade = 10,
                Nome = "Maria"
            };

            var copiaDepStruct = depStruct;
            Console.WriteLine($"nome dep:{depStruct.Nome} - nome copia Dep:{copiaDepStruct.Nome}"); //SERAO IGUAIS
            Console.WriteLine($"idade dep:{depStruct.Idade} - idade copia Dep:{copiaDepStruct.Idade}"); //SERAO IGUAIS

            depStruct.Idade = 30;
            depStruct.Nome = "Rita";
            Console.WriteLine($"nome dep:{depStruct.Nome} - nome copia Dep: {copiaDepStruct.Nome}"); //vão ser diferentes, pois a copia é por valor (struct)
            Console.WriteLine($"idade dep:{depStruct.Idade} - idade copia Dep: {copiaDepStruct.Idade}"); //vão manter diferentes, pois a copia é por valor(struct)


        }
    }
}
