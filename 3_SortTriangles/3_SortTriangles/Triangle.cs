using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_SortTriangles
{
    public class Triangle : IComparable
    {
        string name;
        double a, b, c;
        public string Name { get => name; set => name = value; }
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public Triangle(string name, double a, double b, double c)
        {
            Name = name;
            A = a;
            B = b;
            C = c;          
        }
        public double HalfPerimeter()
        {
            return (A + B + C) / 2;
        }
        public double Square()
        {
            double hp = HalfPerimeter();
            return Math.Round(Math.Sqrt(hp * (hp - A) * (hp - B) * (hp - C)),5);
        }
        override public string ToString()
        {
            return "Triangle " + Name.ToLower() + ": " + Square() + " cm";
        }

        public int CompareTo(object obj)
        {
            Triangle temp = (Triangle)obj;
            if (this.Square() < temp.Square())
                return 1;
            else if (this.Square() == temp.Square())
                return 0;
            return -1;
        }
    }
}
