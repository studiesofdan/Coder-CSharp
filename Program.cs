using System;
using System.Collections.Generic;

using Coder_CSharp.Fundamentos;

namespace Coder_CSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Exercicios},
                {"Comentarios - Fundamentos", Comentarios.Exercicios},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Exercicios},
                {"Inferencia - Fundamentos", Inferencia.Exercicios},
            });

            central.SelecionarEExecutar();
        }
    }
}