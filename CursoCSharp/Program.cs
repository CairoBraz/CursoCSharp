using System;
using System.Collections.Generic;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Fundamentos;
using CursoCSharp.ClassesEMembros;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar },
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferência - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo dados - Fundamentos", LendoDados.Executar },
                {"Formatando Numeros - Fundamentos", FormatandoNumero.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operador Ternario  - Fundamentos", OperadorTernario.Executar },

                // Estruturas de controle
                {"EstruturaIf  - Estruturas de Conrole", EstruturaIf.Executar },
                {"Estrutura If Else  - Estruturas de Conrole", EstruturaIfElse.Executar },
                {"Estrutura If ElseIf - Estruturas de Conrole", EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Estruturas de Conrole", EstruturaSwitch.Executar },
                {"Estrutura While - Estruturas de Conrole", EstruturaWhile.Executar },
                {"Estrutura DoWhile - Estruturas de Conrole", EstruturaDoWhile.Executar },
                {"Estrutura For - Estruturas de Conrole", EstruturaFor.Executar },
                {"Estrutura Foreach - Estruturas de Conrole", EstruturaForeach.Executar },
                {"Usando Break - Estruturas de Conrole", UsandoBreak.Executar },
                {"Usando Continue - Estruturas de Conrole", UsandoContinue.Executar },

                // Classes e Métodos
                {"Membros - Classes e Metodos", Membros.Executar },
                {"Construtores - Classes e Metodos", Construtores.Executar },
                {"Metodos Com Retorno - Classes e Metodos", MetodosComRetorno.Executar },
                {"Metodos Estaticos - Classes e Metodos", MetodosEstaticos.Executar },
                {"Atributos Estaticos - Classes e Metodos", AtributosEstaticos.Executar },
                {"Desafio Atributo - Classes e Metodos", DesafioAtributo.Executar },
                {"Params - Classes e Metodos", Params.Executar },
                {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar },
                {"GetSet - Classes e Metodos", GetSet.Executar },
                {"Props - Classes e Metodos", Props.Executar },
                {"ReadOnly - Classes e Metodos", Readonly.Executar },
                {"Enum - Classes e Metodos", ExemploEnum.Executar },
                {"Exemplo Struct - Classes e Metodos", ExStruct.Executar },
                {"Struct Vs Classe - Classes e Metodos", StructVsClasse.Executar },
                {"Valor Vs Referencia - Classes e Metodos", ValorVsReferencia.Executar },
                {"Parâmetros por Referência - Classes e Metodos", ParametrosPorReferencia.Executar },
                {"Parâmetro Padrão - Classes e Metodos", ParametroPadrao.Executar },



            });

            central.SelecionarEExecutar();
        }
    }
}