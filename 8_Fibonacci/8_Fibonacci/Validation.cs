using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Fibonacci
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

        public static bool Validate(string str, out long number)
        {
            if (!Int64.TryParse(str, out number))
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
        public static bool IsPositive(long number)
        {
            if (number < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter positive!\n");
                Console.ResetColor();
                return false;
            }
            return true;
        }
        public static bool ValidateMinMax(long min, long max)
        {
            if (min >= max)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Minimum must be less than maximun.\n");
                Console.ResetColor();
                return false;
            }
            return true;
        }
    }
}
