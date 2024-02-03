using System;
using Tabuleiro;

namespace console_chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao posicao = new Posicao(3, 4);

            Console.WriteLine(posicao);
        }
    }
}
