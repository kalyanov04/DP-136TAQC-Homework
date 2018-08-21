using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_EnvelopeAnalysis
{
    public static class Validation
    {
        public static bool IsNumber(string str, out double number)
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
