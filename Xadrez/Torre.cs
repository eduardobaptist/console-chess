﻿using System;
using Tabuleiro;

namespace Xadrez
{
    public class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro.Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "T ";
        }
    }
}
