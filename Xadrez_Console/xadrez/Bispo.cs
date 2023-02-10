using System;
using tabuleiro;

namespace xadrez
{
    internal class Bispo : Peca
    {
        public Bispo(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "B";
        }
    }
}
