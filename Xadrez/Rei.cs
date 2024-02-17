using System;
using Tabuleiro;

namespace Xadrez
{
    internal class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro.Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "R ";
        }
    }
}
