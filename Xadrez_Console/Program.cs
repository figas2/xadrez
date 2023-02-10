﻿using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 9));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 9));

                Tela.imprimirTabuleiro(tab);

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}