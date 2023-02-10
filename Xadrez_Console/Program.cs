using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 0));
            Tela.imprimirTabuleiro(tab);

            
            Console.ReadLine();

        }
    }
}