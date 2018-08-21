using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _7_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("--Select menu--\n1.Create sequence\n2.Exit");
                ConsoleKeyInfo selection = Console.ReadKey();

                switch (selection.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        int length = Input.InputLegthOfSequence();
                        double number = Input.InputNumber();
                        Sequence sequence = new Sequence(length, number);
                        Console.WriteLine("Sequence: " + sequence.ToString());
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\bYou did not select menu!");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        break;
                }
            }
        }
    }
}
