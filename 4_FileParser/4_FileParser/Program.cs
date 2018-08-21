using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_FileParser
{
    class Program
    {
        public static string InputPath()
        {
            for (; ; )
            {
                Console.WriteLine("Enter file name:");
                Console.Write("--> ");
                StringBuilder path = new StringBuilder(@"..\..\");
                path.Append(Console.ReadLine());
                if (File.Exists(path.ToString()))
                    return path.ToString();
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter valid path\n");
                    Console.ResetColor();
                }
            }
        }
        static void Main(string[] args)
        {
            string path = InputPath();
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("--Select mode--\n1.Count a string in file\n2.Replace string with a new one\n3.Exit");
                ConsoleKeyInfo selection = Console.ReadKey();
                Console.Clear();

                Parser parser = new Parser(path.ToString());

                switch (selection.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Enter string");
                        string str = Console.ReadLine();
                        Console.WriteLine("Text contains {0} {1}", parser.CountSubstring(str), str);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("Enter string for replacing");
                        string old = Console.ReadLine();
                        Console.WriteLine("Enter new string");
                        string newstring = Console.ReadLine();
                        parser.ReplaceString(old, newstring);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Select menu!");
                        Console.ResetColor();
                        break;
                }
            }     
        }
    }
}
