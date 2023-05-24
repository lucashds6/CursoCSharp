
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

 

namespace CursoCSharp.ClassesEMetodos {

    class MetodosComRetorno {



        class CalculadoraComum {

            public int Somar(int a, int b) {

                return a + b;

            }



            public int Multiplicacao(int a, int b) {

                return a * b;

            }



            public int Divisao(int a, int b) {

                return a / b;

            }



            public int Subtrair(int a, int b) {

                return a - b;

            }



        }

        public static void Executar() {

            //Instanciando o meu objeto Calculadora Comum
            var calculadoraComum = new CalculadoraComum();

            //chamando o meu método
            var resultado = calculadoraComum.Somar(27, 42);
            Console.WriteLine(resultado);

            Console.WriteLine(calculadoraComum.Subtrair(5,18));



        }

    }

}



