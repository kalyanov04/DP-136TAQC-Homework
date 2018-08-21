using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_Chessboard
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("--Select menu--\n1.Create chessboard\n2.Exit");
                ConsoleKeyInfo selection = Console.ReadKey();

                switch (selection.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        int boardLength = Input.InputSizeOfChessboard("length");
                        int boardWidth = Input.InputSizeOfChessboard("width");
                        ChessBoard chess = new ChessBoard(boardLength, boardWidth);
                        chess.Print();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\bYou did not select menu!");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        break;
                }
                
            }
        }
    }
}
