using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Chessboard
{
    class ChessBoard
    {
        int length;
        int width;
        string [,] board;
        public ChessBoard( int length, int width )
        {
            this.length = length;
            this.width = width;
            board = createBoard(length, width);
        }
        private string[,] createBoard(int length, int width)
        {
            string[,] board = new string[length, width];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if ((i % 2 != 0 && j % 2 != 0) || (i % 2 == 0 && j % 2 == 0)) 
                        board[i, j] = "■ ";
                    else
                        board[i, j] = "  ";     
                }
            }
            return board;
        }
        public void Print()
        {
            for ( int i = 0; i < this.length; i++ )
            {
                for ( int j = 0; j < this.width; j++ )
                {
                    Console.Write(this.board[i, j]);  
                }
                Console.WriteLine();
            }
        }
    }
}
