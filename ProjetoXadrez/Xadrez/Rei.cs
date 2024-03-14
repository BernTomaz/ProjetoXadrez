using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoXadrez.tabuleiro;
using ProjetoXadrez.tabuleiro.Enum;

namespace ProjetoXadrez.xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }

}
