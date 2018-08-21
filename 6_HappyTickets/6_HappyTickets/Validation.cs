using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_HappyTickets
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
        public static bool IsTicket(int number)
        {
            if (number >= 0 && number <= 999999)
                return true;
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter number up to 6 digits.\n");
                Console.ResetColor();
                return false;
            }
        }

        public static bool ValidateMinMax(int min, int max)
        {
            if(min>=max)
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
