using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {
    class ExemploLambda {
        public static void Executar() {

            //criando a função
            Action algoNoConsole = () => {
                Console.WriteLine("Palmeiras **TEM** MUNDIAL!!!!!!");
            };
            //chamando a função
            //algoNoConsole();

            //criando uma função com retorno
            Func<int> JogarDado = () => {
                Random random = new Random();
                return random.Next(1, 6);
            };
            Console.WriteLine($"O numero sorteado é: {JogarDado()}");

            Func<int, int, int, string> formatarData = (dia,mes, ano) => {
                return string.Format("{0:D2} / {1:D2} / {2:D2}", dia, mes, ano);
            };
            Console.WriteLine( formatarData(01,10,2002));

            Func<int, bool> ParOuImpar = (numero) => {
                if (numero % 2 == 0) {
                    return true;
                } else {
                    return false;
                }
            };

            Console.WriteLine(ParOuImpar(4));
        }
    }
}
