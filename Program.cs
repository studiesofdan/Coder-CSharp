﻿using System;
using System.Collections.Generic;

using Coder_CSharp.Fundamentos;
using Coder_CSharp.EstruturasDeControle;
using Coder_CSharp.ClassesEMetodos;
using Coder_CSharp.ClassesEMetodos.Construtores;
using Coder_CSharp.ClassesEMetodos._03___MetodosComRetorno;
using Coder_CSharp.ClassesEMetodos._04___MetodosEstaticos;
using Coder_CSharp.ClassesEMetodos._05___AtributosEstaticos;

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
                {"Estrutura Break - Estruturas de Controle", EstruturaBreak.Exercicios},
                {"Estrutura Continue - Estruturas de Controle", EstruturaContinue.Exercicios},
                
                // Classes e Metodos
                {"Membros - Classes e Metodos", Membros.Exercicios},
                {"Construtores - Classes e Metodos", Construtores.Exercicios},
                {"Metodos com retorno  - Classes e Metodos", MetodosComRetorno.Exercicios},
                {"Metodos Estaticos  - Classes e Metodos", MetodosEstaticos.Exercicios},
                {"Atributos Estaticos  - Classes e Metodos", AtributosEstaticos.Exercicios},
            });

            central.SelecionarEExecutar();
        }
    }
}