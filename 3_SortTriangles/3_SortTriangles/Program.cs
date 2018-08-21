using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_SortTriangles
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            string triangleName = "";
            double sideA, sideB, sideC;
            ArrayList triangles = new ArrayList();

            do
            {
                Console.Clear();
                Input.InputTriangleParameters(out triangleName, out sideA, out sideB, out sideC);
                triangles.Add(new Triangle(triangleName, sideA, sideB, sideC));

                Console.WriteLine("Do you want to add another triangle?");
                answer = Console.ReadLine();
                Console.WriteLine();

            } while (answer.ToLower() == "y" || answer.ToLower() == "yes");

            triangles.Sort();

            Console.Clear();
            foreach (var item in triangles)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
}
