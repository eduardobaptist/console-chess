using System;
using Tabuleiro;

namespace console_chess
{
    public class Tela
    {
        public static void imprimeTabuleiro(Tabuleiro.Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.NumLinhas; i++)
            {
                for (int j = 0; j < tabuleiro.NumColunas; j++)
                {

                    if (tabuleiro.getPeca(i, j) == null)
                    {
                        Console.Write("_ ");
                    } else
                    {
                        Console.Write(tabuleiro.getPeca(i, j));
                    }
                    
                }

                Console.WriteLine();
            }
        }
    }
}
