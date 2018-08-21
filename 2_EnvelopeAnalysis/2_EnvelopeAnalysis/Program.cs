using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_EnvelopeAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            do
            {
                Console.Clear();
                Console.WriteLine("--Envelope 1--");
                Envelope envelope1 = new Envelope(Input.InputSizeOfEnvelope("length"), Input.InputSizeOfEnvelope("width"));
                Console.WriteLine("\n--Envelope 2--");
                Envelope envelope2 = new Envelope(Input.InputSizeOfEnvelope("length"), Input.InputSizeOfEnvelope("width"));

                if(Envelope.IsFit(envelope1, envelope2))
                    Console.WriteLine("Envelope 1 fits into Envelope 2");
                else if (Envelope.IsFit(envelope2, envelope1))
                    Console.WriteLine("Envelope 2 fits into Envelope 1");
                else
                    Console.WriteLine("Envelopes don't fit");

                Console.WriteLine("\nDo you want to continue?");
                answer = Console.ReadLine();
                Console.WriteLine();
            } while (answer.ToLower() == "yes" || answer.ToLower() == "y");
        }
    }
}
