using System;
using Tabuleiro;
using Xadrez;

namespace console_chess
{
    public class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro.Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.NumLinhas; i++)
            {
                Console.Write($" {8 - i} ");
                for (int j = 0; j < tabuleiro.NumColunas; j++)
                {

                    if (tabuleiro.GetPeca(i, j) == null)
                    {
                        Console.Write("[ ]");
                    }
                    else
                    {
                        ImprimirPeca(tabuleiro.GetPeca(i, j));
                        
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine($"    A  B  C  D  E  F  G  H");
        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca.Cor == Cor.Preto)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"[{peca}]");
                Console.ForegroundColor = ConsoleColor.White;
            } else
            {
                Console.Write($"[{peca}]");
            }
        }
        
        public static PosicaoXadrez LerPosicaoXadrez(string posicao)
        {
            char coluna = posicao[0];
            int linha = int.Parse(posicao[1].ToString());
            return new PosicaoXadrez(coluna, linha);
        }
    }
}
