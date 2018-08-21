using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_EnvelopeAnalysis
{
    public class Envelope
    {
        double length;
        double width;
        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }

        public Envelope(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public static bool IsFit(Envelope envelope1, Envelope envelope2)
        {
            if (((envelope1.Length < envelope2.Length) && (envelope1.Width < envelope2.Width)) ||
                    ((envelope1.Length < envelope2.Width) && (envelope1.Width < envelope2.Length)))
                return true;
            else
                return false;
        }
    }
}
