using System;
using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Program {
        static void Main(String[] args) {

            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
            

        }

    }

}

