using System;
using tabuleiro;

namespace xadrez
{
    internal class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "C";
        }
    }
}