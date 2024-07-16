using System;
using Tabuleiro;

namespace Xadrez
{
    public class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro.Tabuleiro tabuleiro) : base(cor, tabuleiro)
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
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matrizPossivel[posicao.Linha, posicao.Coluna] = true;
            }


            //Nordeste
            posicao.Definir(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matrizPossivel[posicao.Linha, posicao.Coluna] = true;
            }


            //Direita
            posicao.Definir(Posicao.Linha, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matrizPossivel[posicao.Linha, posicao.Coluna] = true;
            }


            //Sudeste
            posicao.Definir(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matrizPossivel[posicao.Linha, posicao.Coluna] = true;
            }


            //Abaixo
            posicao.Definir(Posicao.Linha + 1, Posicao.Coluna);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matrizPossivel[posicao.Linha, posicao.Coluna] = true;
            }


            //Sudoeste
            posicao.Definir(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matrizPossivel[posicao.Linha, posicao.Coluna] = true;
            }


            //Esquerda
            posicao.Definir(Posicao.Linha, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matrizPossivel[posicao.Linha, posicao.Coluna] = true;
            }


            //Noroeste
            posicao.Definir(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matrizPossivel[posicao.Linha, posicao.Coluna] = true;
            }


            return matrizPossivel;
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
