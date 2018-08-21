using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5_NumberToText
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("--Select menu--\n1.Write number\n2.Exit");
                ConsoleKeyInfo selection = Console.ReadKey();

                switch (selection.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        long number = Converter.Input();
                        Console.WriteLine(Converter.ConvertToString(number));
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\bYou didn't select menu!");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        break;
                }
            }
        }
    }
}
