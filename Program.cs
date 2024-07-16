using System;
using Tabuleiro;
using Xadrez;

namespace console_chess
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Partida partida = new Partida();

                while (!partida.PartidaTerminada)
                {
                    Console.Clear();

                    Tela.ImprimirTabuleiro(partida.Tabuleiro);

                    Console.Write("Insira a posição de origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez(Console.ReadLine().ToLower()).ToPosicao();

                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tabuleiro, partida.Tabuleiro.GetPeca(origem).GetMovimentosPossiveis());

                    Console.WriteLine();
                    Console.Write("Insira a posição de destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez(Console.ReadLine().ToLower()).ToPosicao();

                    partida.ExecutarMovimento(origem, destino);

                    Tela.ImprimirTabuleiro(partida.Tabuleiro);
                }
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
