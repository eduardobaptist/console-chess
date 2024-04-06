using System;
using Tabuleiro;
using Xadrez;

namespace console_chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro.Tabuleiro tabuleiro = new Tabuleiro.Tabuleiro(8, 8);

                tabuleiro.ColocarPeca(new Torre(Cor.Preto, tabuleiro), new Posicao(0, 0));
                tabuleiro.ColocarPeca(new Torre(Cor.Preto, tabuleiro), new Posicao(1, 3));
                tabuleiro.ColocarPeca(new Rei(Cor.Preto, tabuleiro), new Posicao(1, 4));
                tabuleiro.ColocarPeca(new Rei(Cor.Branco, tabuleiro), new Posicao(1, 5));
                tabuleiro.ColocarPeca(new Rei(Cor.Preto, tabuleiro), new Posicao(1, 6));

                Tela.ImprimirTabuleiro(tabuleiro);

                //PosicaoXadrez posicaoXadrez = new PosicaoXadrez('c', 7);
                //Console.WriteLine(posicaoXadrez.ToPosicao());
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();
        }
    }
}
