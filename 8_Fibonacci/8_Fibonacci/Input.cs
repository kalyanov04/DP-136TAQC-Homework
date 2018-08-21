using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Fibonacci
{
    public static class Input
    {
        private static long InputTemplate(string parameter)
        {
            for (; ; )
            {
                Console.WriteLine("Enter {0}", parameter);
                Console.Write("--> ");
                if (Validation.Validate(Console.ReadLine(), out long number) && Validation.IsPositive(number))
                    return number;
            }
        }
        public static void InputRange(out long min, out long max)
        {
            do
            {
                min = InputTemplate("minimum");
                max = InputTemplate("maximum");
            } while (!Validation.ValidateMinMax(min, max));
        }
        public static int InputLength()
        {
            int length;
            do
            {
                length = (int)InputTemplate("length");
                if (length > long.MaxValue.ToString().Length)
                    Console.WriteLine("Program doesn't suppor so big lengths. (Enter <= 19)");
            } while (length > long.MaxValue.ToString().Length);
            return length;
        }
    }
}
