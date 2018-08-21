using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_NumberToText
{
    public static class Validation
    {
        public static bool Validate(string str, out long number)
        {
            if (!Int64.TryParse(str, out number) || number == long.MinValue)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter an integer betwewn -9 223 372 036 854 775 807 and 9 223 372 036 854 775 807!\n");
                Console.ResetColor();
                return false;
            }
            return true;
        }
    }
}
