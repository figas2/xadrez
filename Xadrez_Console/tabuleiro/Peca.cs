using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QuantMov { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            this.posicao = null;
            this.cor = cor;
            this.QuantMov = 0;
            this.Tab = tab;
        }

        public void incrementarQteMovimentos()
        {
            QuantMov++;
        }

        public abstract bool[,] movimentosPossiveis();
        
    }
}
