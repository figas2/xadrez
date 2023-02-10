using System;
using tabuleiro;

namespace Xadrez_Console.xadrez
{
    internal class Peao : Peca
    {
        public Peao(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "P";
        }
    }
}