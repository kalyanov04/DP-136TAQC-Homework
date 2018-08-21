using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Chessboard
{
    static class Input
    {
        static public int InputSizeOfChessboard(string side)
        {
            int size;
            for (; ; )
            {
                Console.WriteLine("Enter {0} of chessboard:", side);
                Console.Write("--> ");
                if (Validation.IsInteger(Console.ReadLine(), out size) && Validation.IsPositive(size))
                    return size;
            }
        }
    }
}
