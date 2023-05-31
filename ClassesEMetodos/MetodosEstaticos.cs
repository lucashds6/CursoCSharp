using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class MetodosEstaticos {

        public class CalculadoraEstatica {
            public static int somar(int a, int b) {
                return a + b;
            }
            public static int Multiplicar(int a, int b) {
                return a * b;
            }
        }
       public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine(resultado);
        }
    }
}
