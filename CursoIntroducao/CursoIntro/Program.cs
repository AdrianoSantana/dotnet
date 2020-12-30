using System;
using System.Collections.Generic;
using CursoIntro;
using CursoIntro.Api;
using CursoIntro.ClassesMetodos;
using CursoIntro.Colecoes;
using CursoIntro.Excecoes;
using CursoIntro.Fundamentos;
using CursoIntro.MetodosEFuncoes;
using CursoIntro.OO;
using CursoIntro.TopicosAvancados;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", First.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Membros - Classes e Metodos", Membros.Executar},
                {"Construtores - Classes e Metodos", Construtores.Executar},
                {"Métodos Retorno - Classes e Metodos", MetodosRetorno.Executar},
                {"Métodos Estaticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Metodos", DesafioAtributo.Executar},
                {"Params - Classes e Metodos", Params.Executar},
                {"Params nomeados - Classes e Metodos", ParamsNomeados.Executar},
                {"Get Set - Classes e Metodos", GetSet.Executar},
                {"ReadOnly - Classes e Metodos", ReadOnly.Executar},
                {"Enum - Classes e Metodos", Enuum.Executar},
                {"ParametrosReferencia - Classes e Metodos", ParametrosReferencia.Executar},
                {"Array - Colecoes", ColecoesArray.Executar},
                {"Lista - Colecoes", Lista.Executar},
                {"Fila - Colecoes", ColecoesQueue.Executar},

                {"Heranca - OO", Heranca.Executar},
                {"Construtor This", ConstrutorThis.Executar},
                {"Encapsulamento", Encampsulamento.Executar},
                {"Abstrata", Abstrata.Executar},
                {"Interface", Interfacee.Executar},
                {"Sealed", Sealed.Executar},


                {"Exemplo Lambda", ExemploLambda.Executar},
                {"Delegate Lambda", LambdaDelegate.Executar},
                {"Usando delegate", UsandoDelegate.Executar},
                {"Parametro como função", DelegateParametro.Executar},
                {"Métodos Extensao", MetodosExtensao.Executar},

                {"Exceções - Primeira", Primeiro.Executar},
                {"Exceções - Personalizada", Personalizadas.Executar},


                {"Api - Primeiro Arquivo", PrimeiroArquivo.Executar},
                {"Api - Lendo Arquivo", LendoArquivo.Executar},

                {"Tópicos Avançados", Linq1.Executar},
                {"Tópicos Avançados Linq2", Linq2.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}