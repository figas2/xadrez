﻿using System;
using System.Collections.Generic;
using tabuleiro;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p;
            Tabuleiro tab = new Tabuleiro(8, 8);

            Console.WriteLine(tab);

        }
    }
}