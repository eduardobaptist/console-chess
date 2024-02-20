using System;
using Tabuleiro;

namespace console_chess
{
    public class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro.Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.NumLinhas; i++)
            {
                for (int j = 0; j < tabuleiro.NumColunas; j++)
                {

                    if (tabuleiro.GetPeca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tabuleiro.GetPeca(i, j));
                    }

                }

                Console.WriteLine();
            }

        }
    }
}
