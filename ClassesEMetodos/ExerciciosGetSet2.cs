using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class ExerciciosGetSet2 {

        public class Aluno 
         {
            double n1;
            double n2;
            double n3;

            public double N1 { get; set; }
            public double N2 { get; set; }
            public double N3 { get; set; }

             public double Media() 
            {
                return (N1 + N2 + N3) / 3;
            } 
            public void ImprimirDados() {
                Console.WriteLine($"Nota1 :{N1}, Nota2 :{N2} Nota3 :{N3} ");
                Console.WriteLine($"Sua nota final é: {Media()}");
            }
    
        }

        public static void Executar() {

            var aluno = new Aluno();
            aluno.N1 = 10.0;
            aluno.N2 = 10.0;
            aluno.N3 = 10.0;
            aluno.ImprimirDados();
        }
    }
}
