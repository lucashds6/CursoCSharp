using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class ExerciciosGetSet3 {
        public class Animal {
            int nome;
            int tipo;

            public string Nome { get; set; }
            public string Tipo { get; set; }

        }




        public static void Executar() {
            var animal = new Animal();


            Console.WriteLine("Informe o nome de uma animal de estimação: ");
            animal.Nome = Console.ReadLine();
            Console.WriteLine("Informe o tipo de uma animal de estimação: ");
            animal.Tipo = Console.ReadLine();
            if (animal.Tipo != "Cachorro" && animal.Tipo != "Gato" && animal.Tipo != "Ave" && animal.Tipo != "cachorro" && animal.Tipo != "gato" && animal.Tipo != "ave") {
                animal.Tipo = "ave";
                Console.WriteLine($"O nome do animal é {animal.Nome} e o tipo dele é {animal.Tipo}");
            } else {
                Console.WriteLine($"O nome do animal é {animal.Nome} e o tipo dele é {animal.Tipo}");
            }




        }
    }
}