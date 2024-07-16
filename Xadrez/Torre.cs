using System;
using Tabuleiro;

namespace Xadrez
{
    public class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro.Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {
        }

        private bool PodeMover(Posicao posicao)
        {
            //Pode mover se não houver peça ou esta seja adversária 
            return Tabuleiro.GetPeca(posicao) is null || Tabuleiro.GetPeca(posicao).Cor != Cor;
        }

        public override bool[,] GetMovimentosPossiveis()
        {
            bool[,] matrizPossivel = new bool[Tabuleiro.NumLinhas, Tabuleiro.NumColunas];

            //Acima
            Posicao posicao = new Posicao(Posicao.Linha - 1, Posicao.Coluna);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matrizPossivel[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.GetPeca(posicao) != null && Tabuleiro.GetPeca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.Linha--;
            }

            //Dieita
            posicao.Definir(Posicao.Linha, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matrizPossivel[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.GetPeca(posicao) != null && Tabuleiro.GetPeca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.Coluna++;
            }

            //Abaixo
            posicao.Definir(Posicao.Linha + 1, Posicao.Coluna);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matrizPossivel[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.GetPeca(posicao) != null && Tabuleiro.GetPeca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.Linha++;
            }

            //Esquerda
            posicao.Definir(Posicao.Linha, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matrizPossivel[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.GetPeca(posicao) != null && Tabuleiro.GetPeca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.Coluna--;
            }

            return matrizPossivel;
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
