using System;
using System.Collections.Generic;

using TesteTarget.Exercicios;

namespace TesteTarget{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Exercicio - Exercicios", Exercicio01.Executar},
                {"Segundo  Exercicio - Exercicios", Exercicio02.Executar},
                {"Terceiro  Exercicio - Exercicios", Exercicio03.Executar},
                {"Quarto  Exercicio - Exercicios", Exercicio04.Executar},
                {"Quinto  Exercicio - Exercicios", Exercicio05.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}