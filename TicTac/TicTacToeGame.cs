using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac
{
    public class TicTacToeGame
    {
        static char[] arr = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;
        public static void Board()
        {
            Console.WriteLine("     |     |      ");
           
            Console.WriteLine("     |     |      ");
          
            Console.WriteLine("     |     |      ");
        }

        public static void Input()
        {
            Console.WriteLine("Player1:X and Player2:O");
            if (player % 2 == 0)
            {
                Console.WriteLine("Player 2 Chance");
            }
            else
            {
                Console.WriteLine("Player 1 Chance");
            }
        }
    }
}
