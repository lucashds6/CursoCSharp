using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.Poo;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;

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
                {"Exercicio de laço de repeticao - Estrutura de Controle",ExerciciosRepeticao.Executar },

                //Classes e Métodos
                {"Membros - Classes e Métodos",Membros.Executar},
                {"Métodos Com Retorno - Classes e Métodos",MetodosComRetorno.Executar},
                {"Exercicios com Metodos com retorno - Classe e método",ExerciciosMetodosComRetorno.Executar },
                {"Métodos Estáticos - Classes e Métodos",MetodosEstaticos.Executar },
                {"Metodos de Param - Classes e Métodos",Params.Executar },
                {"Get e Set - Classes e Método",GetSet.Executar },
                {"Get e Set Segundo Exemplo - Classes e Métodos",GetESetSegundoExemplo.Executar },
                {"Exercicios Get Set - Classes e Métodos",ExerciciosGetSet.Executar },
                {"Exercicios2 Get Set - Classes e métodos",ExerciciosGetSet2.Executar },
                {"Exercicios3 Get Set - Classes e métodos",ExerciciosGetSet3.Executar },

                //colecoes
                {"Arrays - Coleções",Arrays.Executar },
                {"Coleção Queue - Coleções",colecoesQueue.Executar },
                {"Coleções de Stack - Coleções",ColecoesStack.executar },

                //Poo
                {"Herança - Poo ",Heranca.Executar},
                {"Construtor This - Poo",ConstrutorThis.Executar },
             //   {"Encapsulamento - Poo",Encapsulamento.Executar},
                {"Polimorfismo - Poo",Polimorfismo.Executar  },
                {"Exercicios de Polimorfismo - Poo",ExercicioPolimorfismo.Executar },
                {"Abstract - Poo",Abstract.Executar },
                {"Sealed - Poo",Sealed.Executar },

                //Métodos e Funções
                {"Exemplo Lambda - Metodos e Funções",ExemploLambda.Executar },
               
                {"Primeira Exceção - Exceção",PrimeiraExcecao.Executar }
            }); ; 

            central.SelecionarEExecutar();
        }
    }
}