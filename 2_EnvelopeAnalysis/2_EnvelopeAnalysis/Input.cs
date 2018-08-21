using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_EnvelopeAnalysis
{
    class Input
    {
        static public double InputSizeOfEnvelope(string side)
        {
            double size;
            for (; ; )
            {
                Console.WriteLine("Enter {0} of envelope:", side);
                Console.Write("--> ");
                if (Validation.IsNumber(Console.ReadLine(), out size) && Validation.IsPositive(size))
                    return size;
            }
        }
    }
}
