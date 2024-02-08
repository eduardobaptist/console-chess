using System;

//Classe criada como tabuleiro "genérico", não apenas para xadrez (8x8)

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
    }
}
