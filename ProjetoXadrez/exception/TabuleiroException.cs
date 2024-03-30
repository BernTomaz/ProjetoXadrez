 using System;
using tabuleiro;


namespace exception
{
    internal class TabuleiroException : Exception
    {
        public TabuleiroException(string msgErro) : base(msgErro)
        {

        }
    }
}
