using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro.Enum;
using xadrez;



namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtedMovimento { get; protected set; }

        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QtedMovimento = 0;
        }
        public void incrementarQtedMovimentos()
        {
            QtedMovimento++;
        }

        public abstract bool[,] movimentosPossiveis();

    }
}
