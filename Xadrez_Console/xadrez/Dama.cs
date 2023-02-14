using System;
using tabuleiro;

namespace xadrez
{
    internal class Dama : Peca
    {
        public Dama(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "D";
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
            pos.definirValores(posicao.Linha - 1, posicao.Coluna);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Linha = pos.Linha - 1;
            }
            //abaixo
            pos.definirValores(posicao.Linha + 1, posicao.Coluna);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Linha = pos.Linha + 1;
            }
            // direita
            pos.definirValores(posicao.Linha, posicao.Coluna + 1);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna + 1;
            }
            //esquerda
            pos.definirValores(posicao.Linha, posicao.Coluna - 1);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna - 1;
            }

            //noroeste
            pos.definirValores(posicao.Linha - 1, posicao.Coluna + 1);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna + 1;
                pos.Linha = pos.Linha - 1;
            }

            //sudoeste
            pos.definirValores(posicao.Linha + 1, posicao.Coluna + 1);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna + 1;
                pos.Linha = pos.Linha + 1;
            }

            //sudeste
            pos.definirValores(posicao.Linha + 1, posicao.Coluna - 1);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna - 1;
                pos.Linha = pos.Linha + 1;
            }

            //nordheste
            pos.definirValores(posicao.Linha - 1, posicao.Coluna - 1);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna - 1;
                pos.Linha = pos.Linha - 1;
            }
            return mat;
        }
    }
}