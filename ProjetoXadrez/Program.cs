using System;
using ProjetoXadrez.tabuleiro;
using ProjetoXadrez.tabuleiro.Enum;
using ProjetoXadrez.xadrez;
using ProjetoXadrez.exception;
using ProjetoXadrez.xadrez;




namespace ProjetoXadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);


            Console.WriteLine(pos.toPosicao());
            Console.ReadLine();
        }
    }
}
