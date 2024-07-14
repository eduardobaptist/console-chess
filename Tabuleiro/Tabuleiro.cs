using System;

namespace Tabuleiro
{
    public class Tabuleiro
    {
        public int NumLinhas { get; set; }
        public int NumColunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int numLinhas, int numColunas)
        {
            NumLinhas = numLinhas;
            NumColunas = numColunas;
            Pecas = new Peca[numLinhas, numColunas];
        }

        public Peca GetPeca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        public Peca GetPeca(Posicao posicao)
        {
            return Pecas[posicao.Linha, posicao.Coluna];
        }

        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            if (ExistePeca(posicao))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição.");
            }
            Pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }

        public Peca RetirarPeca(Posicao posicao)
        {
            Peca peca = GetPeca(posicao);

            if (peca != null)
            {
                peca.Posicao = null;
                Pecas[posicao.Linha, posicao.Coluna] = null;

                return peca;
            }
            
            return null;
        }

        public bool ExistePeca(Posicao posicao)
        {
            ValidarPosicao(posicao);
            return GetPeca(posicao) != null;
        }
        public bool PosicaoValida(Posicao posicao)
        {
            if (posicao.Linha < 0 || posicao.Linha >= NumLinhas || posicao.Coluna < 0 || posicao.Coluna >= NumColunas)
            {
                return false;
            }
            return true;
        }

        public void ValidarPosicao(Posicao posicao)
        {
            if (!PosicaoValida(posicao))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
