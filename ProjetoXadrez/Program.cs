using System;
using ProjetoXadrez.tabuleiro;
using ProjetoXadrez.tabuleiro.Enum;



namespace ProjetoXadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);


            Console.WriteLine(tab.Colunas);
            Console.WriteLine(tab.Linhas);
        }
    }
}
