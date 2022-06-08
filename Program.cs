using System;
using System.Collections.Generic;

using Coder_CSharp.Fundamentos;
using Coder_CSharp.EstruturasDeControle;

namespace Coder_CSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
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
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Exercicios},
                {"Operadores de atribuicao - Fundamentos", OperadoresDeAtribuicao.Exercicios},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Exercicios},
                {"Operadores Ternarios - Fundamentos", OperadoresTernarios.Exercicios},
                
                // Estruturas de Controle
                {"Estrutura IF - Estruturas de Controle", EstruturaIf.Exercicios},
                {"Estrutura IF/ELSE - Estruturas de Controle", EstruturaIfElse.Exercicios},
                {"Estrutura IF/ELSE IF - Estruturas de Controle", EstruturaIfElseIf.Exercicios},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Exercicios},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Exercicios},
                {"Estrutura Do/While - Estruturas de Controle", EstruturaDoWhile.Exercicios},
                {"Estrutura FOR - Estruturas de Controle", EstruturaFor.Exercicios},
                {"Estrutura FOREACH - Estruturas de Controle", EstruturaForeach.Exercicios},
            });

            central.SelecionarEExecutar();
        }
    }
}