using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the TicTocToe Game");
            TicTacToeGame.Board();
            TicTacToeGame.Input();
            Console.ReadKey();
        }
    }
}
