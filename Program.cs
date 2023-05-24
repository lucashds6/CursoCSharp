using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos ",NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos",LendoDados.Executar },
                {"Formatando Números - Fundamentos ",FormatandoNumeros.Executar},
                {"Operadores Aritméticos - Fundamentos",OperadoresAritmeticos.Executar },
                {"Exercícios Operadores ",ExerciciosOperadores.Executar},
                {"Operadores Relacionais - Fundamentos",OperadoresRelacionais.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},

                //Estruturas de Controle
                {"Estrutura If - Estruturas de Controle",EstruturaIf.Executar},
                {"Estrutura Switch - Estruturas de Controle",EstruturaSwitch.Executar},
                {"Estrutura While e For - Estruturas de Controle",EstruturaWhileEFor.Executar},
                {"Estrutura ForEach - Estruturas de Controle",EstuturaForEach.Executar},

                //Classes e Métodos
                {"Membros - Classes e Métodos",Membros.Executar},
                {"Métodos Com Retorno - Classes e Métodos",MetodosComRetorno.Executar},
                {"Exercicios com Metodos com retorno - Classe e método",ExerciciosMetodosComRetorno.Executar }
            }); ;

            central.SelecionarEExecutar();
        }
    }
}