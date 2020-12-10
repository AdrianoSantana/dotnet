using System;
using System.Collections.Generic;
using CursoIntro;
using CursoIntro.ClassesMetodos;
using CursoIntro.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", First.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {" Membros - Classes e Metodos", Membros.Executar},
                {" Construtores - Classes e Metodos", Construtores.Executar},
                {"Metodos Retorno - Classes e Metodos", MetodosRetorno.Executar},
                
            });

            central.SelecionarEExecutar();
        }
    }
}