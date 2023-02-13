using System;
using tabuleiro;

namespace xadrez
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

        private bool podeMover(Posicao pos)
        {
            Peca p = Tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //acima
            if (cor == Cor.Branca)
            {
                if (pos.Linha == 2)
                {
                    pos.definirValores(posicao.Linha - 2, posicao.Coluna);

                    if (Tab.posicaoValida(pos) && podeMover(pos))
                    {
                        mat[pos.Linha, pos.Coluna] = true;
                    }
                }
                else
                {
                    pos.definirValores(posicao.Linha - 1, posicao.Coluna);

                    if (Tab.posicaoValida(pos) && podeMover(pos))
                    {
                        mat[pos.Linha, pos.Coluna] = true;
                    }
                }
            }
            if (cor == Cor.Preta)
            {                
                pos.definirValores(posicao.Linha + 1, posicao.Coluna);

                if (Tab.posicaoValida(pos) && podeMover(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }
            return mat;
        }
    }
}