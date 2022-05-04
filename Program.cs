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
                {"Interpolacao - Fundamentos", Interpolacao.Exercicios},
                {"Notacao Ponto - Fundamentos", NotacaoPonto.Exercicios},
                {"Leitura de dados do console - Fundamentos", LeituraDadosConsole.Exercicios},
                {"Formatar numeros - Fundamentos", FormatarNumeros.Exercicios},
                {"Conversoes - Fundamentos", Conversoes.Exercicios},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Exercicios},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Exercicios},
            });

            central.SelecionarEExecutar();
        }
    }
}