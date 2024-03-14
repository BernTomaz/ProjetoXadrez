 using System;
using ProjetoXadrez.tabuleiro;


namespace ProjetoXadrez.exception
{
    internal class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg)
        {

        }
    }
}
