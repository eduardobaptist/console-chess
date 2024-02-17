using System;
using Tabuleiro;
using Xadrez;

namespace console_chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Tabuleiro.Tabuleiro tabuleiro = new Tabuleiro.Tabuleiro(8, 8);

            tabuleiro.ColocarPeca(new Torre(Cor.Preto, tabuleiro), new Posicao(0, 0));
            tabuleiro.ColocarPeca(new Torre(Cor.Preto, tabuleiro), new Posicao(1, 3));
            tabuleiro.ColocarPeca(new Rei(Cor.Preto, tabuleiro), new Posicao(2, 4));
            
            Tela.ImprimirTabuleiro(tabuleiro);

            
            Console.ReadLine();
        }
    }
}
