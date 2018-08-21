using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _8_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("--Select mode--\n1.Range\n2.Length\n3.Exit");
                ConsoleKeyInfo selection = Console.ReadKey();

                switch (selection.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Input.InputRange(out long min, out long max);
                        Fibonacci fibonacciRange = new Fibonacci(min, max);
                        Console.WriteLine(fibonacciRange.ToString());
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        int length = Input.InputLength();
                        Fibonacci fibonacciLength = new Fibonacci(length);
                        Console.WriteLine(fibonacciLength.ToString());
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
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

