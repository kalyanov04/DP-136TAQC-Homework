using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_SortTriangles
{
    public static class Input
    {
        public static void InputTriangleParameters(out string triangleName, out double sideA, out double sideB, out double sideC)
        {
            for (; ; )
            {
                Console.WriteLine("Input parameters of a triangle in the following format: <name>, <a>, <b>, <b>");
                string parameters = Console.ReadLine();
                string[] separator = new string[] { ", " };
                string[] splitedParameters = parameters.Split(separator, StringSplitOptions.None);

                for (int i = 0; i < splitedParameters.Length; i++)
                {
                    splitedParameters[i] = splitedParameters[i].Trim(' ','\t');
                }

                if (splitedParameters.Length < 4 || !Double.TryParse(splitedParameters[1], out sideA) || 
                    !Double.TryParse(splitedParameters[2], out sideB) ||
                    !Double.TryParse(splitedParameters[3], out sideC))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your parameters are not correct\n");
                    Console.ResetColor();
                    continue;
                }
                else
                {
                    if (IsTriangle(sideA, sideB, sideC))
                    {
                        triangleName = splitedParameters[0];
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This is not a triangle. One side must be less than sum of another two sizes\n");
                        Console.ResetColor();
                        continue;
                    }
                }
            }
        }
        public static bool IsTriangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
                return true;
            else
                return false;
        }
    }
}
