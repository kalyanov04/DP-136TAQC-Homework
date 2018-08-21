using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3_SortTriangles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_SortTriangles.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        Triangle triangle;
        Triangle triangle1;
        [TestInitialize()]
        public void TriangleTest()
        {
            triangle = new Triangle("Tr1", 10, 15, 20);
            triangle1 = new Triangle("Triangle 2", 5.6, 7.8, 10);
        }

        [TestMethod()]
        public void HalfPerimeterTest_ObjTriangle()
        {
            double expected = 22.5;
            double actual = triangle.HalfPerimeter();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void HalfPerimeterTest_ObjTriangle1()
        {
            double expected = 11.7;
            double actual = triangle1.HalfPerimeter();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SquareTest_ObjTriangle()
        {
            double expected = 72.61844;
            double actual = triangle.Square();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SquareTest_ObjTriangle1()
        {
            double expected = 21.75277;
            double actual = triangle1.Square();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ToStringTest_ObjTriangle()
        {
            string expected = "Triangle tr1: 72,61844 cm";
            string actual = triangle.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ToStringTest_ObjTriangle1()
        {
            string expected = "Triangle triangle 2: 21,75277 cm";
            string actual = triangle1.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CompareToTest_Triangle1LessThanTriangle()
        {
            int expected = -1;
            int actual = triangle.CompareTo(triangle1);

            Assert.AreEqual(expected, actual);
        }
    }
}