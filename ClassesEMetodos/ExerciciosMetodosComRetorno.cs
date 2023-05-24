using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class ExerciciosMetodosComRetorno {

        /*  class conversao_dinheiro {

              public double conversao(double r)
               {
                  return r * 4.95;
              }


          }
          public static void Executar() {

              Console.WriteLine("Qual o valor deseja converter R$: ");
              double real = double.Parse(Console.ReadLine());

              var dinheiro = new conversao_dinheiro();
              var resposta = dinheiro.conversao(real);

              Console.WriteLine($"{resposta}");



          }*/

        class conversao_tempo {
            public double conversao(double t) {
                return (t * 1.8) + 32;
            }
        }
            public static void Executar() {
                Console.WriteLine("Qual temperatura deseja converter para farenheight?");
                double tempo = double.Parse(Console.ReadLine());

                var temperatura = new conversao_tempo();
                var resposta = temperatura.conversao(tempo);

                Console.WriteLine($"{resposta}");
            }
        }
    }


