using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class Arrays {
        public static void Executar() {

            /* string[] alunos = new string[5];

             alunos[0] = "Vanderlei";
             alunos[1] = "Cleiton";
             alunos[2] = "Rodrigo";
             alunos[3] = "Maria";
             alunos[4] = "Everaldo";

             foreach(var aluno in alunos) {
                 Console.WriteLine(aluno);
             }*/

            double somatorio = 0;
            double[] notas = { 7.5,8.5,6.5};

            foreach(var nota in notas) {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;
            Console.WriteLine(media.ToString("#.##"));



        }
    }
}
