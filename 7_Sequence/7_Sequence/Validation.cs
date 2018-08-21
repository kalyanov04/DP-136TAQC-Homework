using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Sequence
{
    public static class Validation
    {
        public static bool Validate(string str, out int number)
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

        public static bool Validate(string str, out double number)
        {
            if (!Double.TryParse(str, out number))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter number!\n");
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
        public static bool IsPositive(double number)
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
