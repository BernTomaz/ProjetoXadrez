using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoXadrez.tabuleiro.Enum;



namespace ProjetoXadrez.tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtedMovimento { get; protected set; }

        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, int qtedMovimento, Tabuleiro tab)
        {
            Posicao = posicao;
            Cor = cor;
            Tab = tab;
            QtedMovimento = 0;
        }
    }
}
