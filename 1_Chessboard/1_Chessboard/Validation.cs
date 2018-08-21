using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Chessboard
{
    public static class Validation
    {
        public static bool IsInteger(string str, out int number)
        {
            if (!Int32.TryParse(str, out number))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter integer number!\n");
                Console.ResetColor();
                return false;
            }
            return true;
        }
        public static bool IsPositive(int number)
        {
            if (number <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter positive!\n");
                Console.ResetColor();
                return false;
            }
            return true;
        }
    }
}
