using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Sequence
{
    static class Input
    {
        static public int InputLegthOfSequence()
        {
            for (; ; )
            {
                Console.WriteLine("Enter length of sequence");
                Console.Write("--> ");
                if (Validation.Validate(Console.ReadLine(), out int length) && Validation.IsPositive(length))
                    return length;
            }
        }
        static public double InputNumber()
        {
            for (; ; )
            {
                Console.WriteLine("Enter number");
                Console.WriteLine("--> ");
                if (Validation.Validate(Console.ReadLine(), out double number) && Validation.IsPositive(number))
                    return number;
            }
        }
    }
}
