using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Poo {
    class ExercicioPolimorfismo {

        public class Cliente {
            public string Nome;
            public string Tipo;
        }

        public class Juridico : Cliente {
            public string Cnpj;
        }

        public class Fisico : Cliente {
            public string Cpf;
        }
        public static void Executar() {

            Cliente pessoa1 = new Cliente();



            Console.WriteLine("Qual o seu nome ?");
            pessoa1.Nome = Console.ReadLine();

            Console.WriteLine("Você é uma pessoa Jurítica ou Física ?");
            pessoa1.Tipo = Console.ReadLine();

            Console.WriteLine($"{pessoa1.Nome} Você é uma pessoa {pessoa1.Tipo}");
        }
    }
}
