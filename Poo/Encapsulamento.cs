using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;

namespace CursoCSharp.Poo {

    public class FilhoNaoReconhecido : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("Filho não reconhecido");
            Console.WriteLine(InforPublica);
            Console.WriteLine(CorDoOlho);
        }
    }
    class Encapsulamento {
        public static void Executar() {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();

        }
    }
}
