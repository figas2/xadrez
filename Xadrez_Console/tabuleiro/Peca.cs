using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QuantMov { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, int quantMov, Tabuleiro tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.QuantMov = quantMov;
            this.Tab = tab;
        }
    }
}
