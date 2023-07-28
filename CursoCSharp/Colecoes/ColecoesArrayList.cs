using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesArrayList
    {
        public static void Executar()
        {
            //ArrayList serve para armazenar um array de tipos diferentes.
            var arrayList = new ArrayList //disponível em System.Collections;
            {
                "Palavra",
                3,
                true
            };

            arrayList.Add(3.14); // arrayList pode ser incrementado

            foreach (var item in arrayList)
            {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}
