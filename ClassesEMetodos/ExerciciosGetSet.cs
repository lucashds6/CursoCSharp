using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class ExerciciosGetSet {

    public class Pessoa 
            {
            string nome;
            double altura;
            DateTime data;

            public string Nome { get; set; }
            public double Altura { get; set; }
            public DateTime Data { get; set; }

           public void ImprimirDados() {
                Console.WriteLine($"Seu nome é:{Nome}, você tem {Altura} metros de altura, {Data}");
            }
            public int CalcularIdade() {
                return DateTime.Today.Year - Data.Year;
            }

        }      
        public static void Executar() {

            var pessoa = new Pessoa();
            pessoa.Nome = "Lucas";
            pessoa.Altura = 1.80;
            pessoa.Data = new DateTime(2002, 10, 01);
            pessoa.CalcularIdade();
            pessoa.ImprimirDados();
            int idade = pessoa.CalcularIdade();
            Console.WriteLine(idade);

        }
    }
}
